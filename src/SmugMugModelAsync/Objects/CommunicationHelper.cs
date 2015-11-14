using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Web;
using System.Threading.Tasks;
using SmugMugModel.oAuth;
using Newtonsoft.Json;

namespace SmugMugModel
{
    public class CommunicationHelper
    {
        public const string baseAddrSecure1_3_0 = "https://secure.smugmug.com/services/api/json/1.3.0/";
        public const string baseAddrNormal1_3_0 = "http://api.smugmug.com/services/api/json/1.3.0/";


        /// <summary>
        /// Will do a call to the SM JSON endpoint and will return the response
        /// </summary>
        /// <param name="method">The method</param>
        /// <param name="args">The arguments</param>
        /// <param name="sessionState">The session state for the call</param>
        public async Task<SMR> ExecuteMethod<SMR>(string method, SmugMugBase sessionState, params object[] args) where SMR : SmugMugResponse
        {
            //most calls go to the normal api
            string baseAddr = baseAddrSecure1_3_0;

            //if we don't have a method or the parameters are not in pairs of 2, bail
            if (string.IsNullOrEmpty(method))
                throw new ArgumentException("The method cannot be null or empty", "method");

            if (args.Length > 0 && args.Length % 2 != 0)
                throw new ArgumentException("The number of arguments must be even", "args");

            // Generate the request string (with the oauth_signature)
            string msg = oAuthUtility.GetMessageParameters(Site.APIKey, Site.ApplicationSecret, method, sessionState != null ? sessionState.AccessToken : null, args);

            //we need to send that request as a stream of bytes.
            var message = System.Text.UTF8Encoding.UTF8.GetBytes(msg);

            var myWebRequest = HttpWebRequest.Create(baseAddr);
            ((HttpWebRequest)myWebRequest).UserAgent = "SmugMugModel_v1.0";

            //do we have a proxy?
            if (Site.Proxy != null && !Site.Proxy.IsBypassed(new Uri(baseAddr)))
                myWebRequest.Proxy = Site.Proxy;

            myWebRequest.ContentType = "application/x-www-form-urlencoded";
            myWebRequest.Method = "POST";
            myWebRequest.ContentLength = message.Length;

            //we send the request
            using (Stream sw = await myWebRequest.GetRequestStreamAsync())
            {
                sw.Write(message, 0, message.Length);
            }

            string result = string.Empty;
            using (var response = await myWebRequest.GetResponseAsync())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
            }

            var temp = JsonConvert.DeserializeObject<SMR>(System.Uri.UnescapeDataString(result));

            return temp;
        }
    }
}