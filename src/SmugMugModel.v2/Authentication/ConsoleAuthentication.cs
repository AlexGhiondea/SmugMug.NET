// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication.Tokens;
using System;
using System.Diagnostics;

namespace SmugMug.v2.Authentication
{
    public class ConsoleAuthentication
    {
        /// <summary>
        /// Use the ITokenProvider to retrieved stored credentials. If they are not available, authorize with SmugMug using the console.
        /// </summary>
        public static OAuthToken GetOAuthTokenFromProvider(ITokenProvider provider)
        {
            OAuthToken oauthToken = default(OAuthToken);
            if (!provider.TryGetCredentials(out oauthToken))
            {
                // Do we have the secret/apikey?
                Console.WriteLine("Please enter your API Key and press [Enter]:");
                string apiKey = Console.ReadLine();
                Console.WriteLine("Please enter your Application Secret and press [Enter]:");
                string secret = Console.ReadLine();

                oauthToken = SmugMugAuthorize.AuthorizeSmugMug(apiKey, secret, AuthenticationOptions.FullAccess);
                provider.SaveCredentials(oauthToken);
            }

#if DEBUG
            Debug.WriteLine("Using APIKey={0}", oauthToken.ApiKey);
            Debug.WriteLine("Using AppSecret={0}", oauthToken.Secret);
            Debug.WriteLine("Using token={0}", oauthToken.Token);
            Debug.WriteLine("Using tokenSecret={0}", oauthToken.TokenSecret);
#endif

            return oauthToken;
        }

        public static OAuthToken GetOAuthTokenFromFileProvider()
        {
            return GetOAuthTokenFromProvider(new FileTokenProvider());
        }
        
        
    }
}
