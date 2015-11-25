// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Authentication;
using System.Diagnostics;

namespace SmugMugMetadataRetriever
{
    class Program
    {
        static OAuthToken s_oauthToken;


        static void Main(string[] args)
        {
            s_oauthToken = SmugMug.Shared.SecretsAccess.GetSmugMugSecrets();
            Debug.Assert(!s_oauthToken.Equals(OAuthToken.Invalid));

        }
    }
}
