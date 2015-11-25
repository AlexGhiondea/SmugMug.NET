// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmugMug.v2.Authentication
{
    public class SmugMugAuthorize
    {
        const string OAuthBaseUrl = "https://secure.smugmug.com";
        const string OAuthGetRequestTokenUrl = OAuthBaseUrl + "/services/oauth/1.0a/getRequestToken";
        const string OAuthAuthorizeUrl = OAuthBaseUrl + "/services/oauth/1.0a/authorize";
        const string OAuthGetAccessTokenUrl = OAuthBaseUrl + "/services/oauth/1.0a/getAccessToken";
        const string NonWebOAuthApplicationCallback = "oob";

        private static async Task<string> GetResponseContent(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await (await client.GetAsync(url)).Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// Use this method to authorize the application to SmugMug.
        /// </summary>
        public static OAuthToken AuthorizeSmugMug(string apiKey, string secret, AuthenticationOptions options)
        {
            OAuth.OAuthAuthenticator authenticator = new OAuth.OAuthAuthenticator(apiKey, secret);

            string reqTokUrl = authenticator.CreateGetRequestTokenAddress(OAuthGetRequestTokenUrl, HttpMethod.Get.ToString(), NonWebOAuthApplicationCallback);
            string tokens = GetResponseContent(reqTokUrl).Result; // requestClient.GetAsync(reqTokUrl).Result.Content.ReadAsStringAsync().Result;

            // Figure out which authorization options are requested (if any)
            string authorizationOptions = options == null ? string.Empty : "?" + options.AsQueryString();
            string authorizeUrl = authenticator.CreateAuthorizeAddress(OAuthAuthorizeUrl + authorizationOptions, tokens);

            Process.Start(authorizeUrl);

            Console.WriteLine("Press [Enter] after you authorized the application and entered the pin provided");
            string pin = Console.ReadLine();

            // Get the request token to exchange for an access token
            string reqToken, reqTokenSecret;
            authenticator.ParseRequestTokens(tokens, out reqToken, out reqTokenSecret);
            string accessTokenUrl = authenticator.CreateGetAccessTokenAddress(OAuthGetAccessTokenUrl, "GET", reqTokenSecret, reqToken, pin);

            string authTokens = GetResponseContent(accessTokenUrl).Result;
            string authToken, authTokenSecret;
            authenticator.ParseRequestTokens(authTokens, out authToken, out authTokenSecret);

            return new OAuthToken(apiKey, secret, authToken, authTokenSecret);
        }
    }
}