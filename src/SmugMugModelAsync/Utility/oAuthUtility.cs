using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Web;

namespace SmugMugModel.oAuth
{
    /// <summary>
    /// Contains methods used in calculating the oAuth signature for the request
    /// </summary>
    internal class oAuthUtility
    {
        const string oauth_consumer_key = "oauth_consumer_key";
        const string oauth_token = "oauth_token";
        const string oauth_signature_method = "oauth_signature_method";
        const string oauth_timestamp = "oauth_timestamp";
        const string oauth_nonce = "oauth_nonce";
        const string oauth_signature = "oauth_signature";
        const string oauth_token_secret = "oauth_token_secret";
        const string oauth_version = "oauth_version";

        /// <summary>
        /// Normalizes the parameters according to the oAuth spec:
        /// - Sort the parameters lexicografically
        /// - Concatenate them into a query string
        /// </summary>
        static string NormalizeParameters(List<KeyValuePair<string, string>> parameters)
        {
            // create the encoded list of parameters.
            List<KeyValuePair<string, string>> encodedParameters = new List<KeyValuePair<string, string>>();
            foreach (var pair in parameters)
            {
                // The key/value should be Encoded.
                // This does mean that we will encode this twice but this is according to the way SmugMug 
                // and oAuth works.
                KeyValuePair<string, string> newPair = new KeyValuePair<string, string>(
                    EncodeValue(pair.Key),
                    EncodeValue(pair.Value)
                );
                encodedParameters.Add(newPair);
            }

            encodedParameters.Sort(new Comparison<KeyValuePair<string, string>>((param1, param2) =>
                {
                    if (param1.Key == param2.Key)
                    {
                        return string.Compare(param1.Value, param2.Value, StringComparison.Ordinal);
                    }
                    else
                    {
                        return string.Compare(param1.Key, param2.Key, StringComparison.Ordinal);
                    }
                }));

            StringBuilder normalizedParameters = new StringBuilder();
            foreach (var param in encodedParameters)
            {
                normalizedParameters.AppendFormat("{0}={1}&", param.Key, param.Value);
            }
            normalizedParameters.Remove(normalizedParameters.Length - 1, 1);

            return normalizedParameters.ToString();
        }

        /// <summary>
        /// Encodes the value in the manner required by the oAuth
        /// All values not permitted are encoded as % followed by
        /// the value of the character in HEX
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string EncodeValue(string value)
        {
            // unreserved  = ALPHA / DIGIT / "-" / "." / "_" / "~"
            string acceptedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~";

            StringBuilder encodedValue = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                if (acceptedChars.IndexOf(value[i]) >= 0)
                {
                    encodedValue.Append(value[i]);
                }
                else
                {
                    // encode it
                    var bytes = Encoding.UTF8.GetBytes(new char[] { value[i] });
                    for (int j = 0; j < bytes.Length; j++)
                    {
                        encodedValue.Append('%' + bytes[j].ToString("X2"));
                    }
                }
            }

            return encodedValue.ToString();
        }

        /// <summary>
        /// Gets the absolute URI for a request ( no query strings )
        /// </summary>
        static string GenerateBaseStringUri(string host)
        {
            return new Uri(host).AbsoluteUri;
        }

        /// <summary>
        /// Generates the base string for the oAuth request
        /// </summary>
        static string GenerateBaseString(string host, string httpMethod, List<KeyValuePair<string, string>> parameters)
        {
            httpMethod = httpMethod.ToUpperInvariant();
            host = EncodeValue(GenerateBaseStringUri(host));
            string param = EncodeValue(NormalizeParameters(parameters));

            return string.Format("{0}&{1}&{2}", httpMethod, host, param);
        }

        /// <summary>
        /// Gets the timestamp in seconds since January 1970 00:00:00AM
        /// </summary>
        static string GenerateTimestamp()
        {
            DateTime jan1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            TimeSpan ts = DateTime.Now.ToUniversalTime() - jan1970;
            return ((long)ts.TotalSeconds).ToString();
        }

        /// <summary>
        /// Generate a unique string for each request
        /// </summary>
        static string GenerateNonce()
        {
            return Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Calculate the HMAC-SHA1 digest for the base string
        /// </summary>
        static string GenerateHMACDigest(string data, string clientSecret, string tokenSecret = "")
        {
            HMACSHA1 hash = new HMACSHA1();
            string key = string.Format("{0}&{1}", EncodeValue(clientSecret), EncodeValue(tokenSecret));

            //the key is the client secret+ "&" + token_secret
            hash.Key = Encoding.UTF8.GetBytes(key);

            byte[] digest = hash.ComputeHash(Encoding.UTF8.GetBytes(data));

            return Convert.ToBase64String(digest);
        }

        /// <summary>
        /// Calculates the message parameters, including the oaut_signature
        /// </summary>
        internal static string GetMessageParameters(string APIKey, string Secret, string methodName, Token tok, params object[] args)
        {
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>(oauth_timestamp, oAuthUtility.GenerateTimestamp() ),
                new KeyValuePair<string,string>(oauth_nonce, oAuthUtility.GenerateNonce() ),
                new KeyValuePair<string,string>(oauth_consumer_key, APIKey),
                new KeyValuePair<string,string>(oauth_signature_method, "HMAC-SHA1"),
                new KeyValuePair<string,string>(oauth_version, "1.0")
            };

            //parameters.Add(new KeyValuePair<string, string>("pretty", "true"));

            var method = new KeyValuePair<string, string>("method", methodName);
            var apikey = new KeyValuePair<string, string>("APIKey", APIKey);

            parameters.Add(method);
            parameters.Add(apikey);

            // add the access token if present
            if (tok != null)
            {
                parameters.Add(new KeyValuePair<string, string>(oauth_token, tok.id));
            }

            for (int i = 0; i < args.Length; i += 2)
            {
                parameters.Add(new KeyValuePair<string, string>(args[i].ToString(), args[i + 1].ToString()));
            }

            string baseString = oAuthUtility.GenerateBaseString(CommunicationHelper.baseAddrSecure1_3_0, "POST", parameters);
            string sig = oAuthUtility.EncodeValue(oAuthUtility.GenerateHMACDigest(baseString, Secret, tok == null ? "" : tok.Secret));

            parameters.Add(new KeyValuePair<string, string>(oauth_signature, sig));

            parameters.Remove(method);
            parameters.Remove(apikey);

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("method={0}&APIKey={1}", methodName, APIKey);

            foreach (var param in parameters)
            {
                sb.AppendFormat("&{0}={1}", param.Key, HttpUtility.HtmlEncode(param.Value));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Calculates teh Authorization header to use with the oAuth authentication
        /// </summary>
        internal static string GetAuthorizationHeader(Token tok, string endpoint, params object[] args)
        {
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>(oauth_timestamp, oAuthUtility.GenerateTimestamp() ),
                new KeyValuePair<string,string>(oauth_nonce, oAuthUtility.GenerateNonce() ),
                new KeyValuePair<string,string>(oauth_consumer_key, Site.APIKey),
                new KeyValuePair<string,string>(oauth_signature_method, "HMAC-SHA1"),
                new KeyValuePair<string,string>(oauth_token, tok.id),
                new KeyValuePair<string,string>(oauth_token_secret, tok.Secret)
            };

            // Add of the other parameters to the mix
            for (int i = 0; i < args.Length; i += 2)
            {
                parameters.Add(new KeyValuePair<string, string>(args[i].ToString(), args[i + 1].ToString()));
            }

            string baseString = oAuthUtility.GenerateBaseString(endpoint, "PUT", parameters);
            string sig = oAuthUtility.EncodeValue(oAuthUtility.GenerateHMACDigest(baseString, Site.ApplicationSecret, tok == null ? "" : tok.Secret));

            parameters.Add(new KeyValuePair<string, string>(oauth_signature, sig));

            // the authorization header only consists of oauth_ tokens


            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("OAuth ");

            foreach (var param in parameters)
            {
                if (param.Key.StartsWith("oauth", StringComparison.OrdinalIgnoreCase))
                {
                    sb.AppendFormat("{0}=\"{1}\",", param.Key, param.Value);
                }
            }
            // remove the trailing ,
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
