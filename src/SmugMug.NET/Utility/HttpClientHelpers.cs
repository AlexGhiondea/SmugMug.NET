// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using System.Net.Http;

namespace SmugMug.v2.Helpers
{
    public static class HttpClientHelpers
    {
        public static HttpClient CreateHttpClient(OAuthToken oauthToken)
        {
            OAuth.OAuthMessageHandler _handler = new OAuth.OAuthMessageHandler(
                oauthToken.ApiKey,
                oauthToken.Secret,
                oauthToken.Token,
                oauthToken.TokenSecret);
            HttpClient client = new HttpClient(_handler);

            // Make sure we request JSON data
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
