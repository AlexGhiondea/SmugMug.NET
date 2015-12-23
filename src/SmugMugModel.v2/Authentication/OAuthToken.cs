// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMug.v2.Authentication
{
    public struct OAuthToken
    {
        public readonly string ApiKey;
        public readonly string Secret;
        public readonly string Token;
        public readonly string TokenSecret;
        public static readonly OAuthToken Invalid = default(OAuthToken);

        public OAuthToken(string apiKey, string secret, string token, string tokenSecret)
        {
            ApiKey = apiKey;
            Secret = secret;
            Token = token;
            TokenSecret = tokenSecret;
        }
    }
}
