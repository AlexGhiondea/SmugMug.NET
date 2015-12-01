// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using SmugMug.v2.Authentication;
using SmugMugShared;
using System.Collections.Generic;
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

            ApiAnalyzer buf = new ApiAnalyzer(s_oauthToken);
            var list = new Dictionary<string, string>();
            list = buf.GetBaseUris(Constants.Addresses.SmugMug, "/api/v2");

            for (int i = 0; i < args.Length; i++)
            {
                list.Add("arg" + i, args[i]);
            }

            Dictionary<string, string> uris = new Dictionary<string, string>();
            foreach (var item in list)
            {
                uris.Add(item.Key, Constants.Addresses.SmugMug + item.Value + Constants.RequestModifiers);
            }

            var types = buf.AnalyzeAPIs(uris, Constants.Addresses.SmugMugApi);
        }
    }
}
