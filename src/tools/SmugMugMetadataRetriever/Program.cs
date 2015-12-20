// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using SmugMug.Shared.Descriptors;
using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using SmugMugShared;
using SmugMugShared.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

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

            var missingTypes = buf.GetMissingTypes();

            // make sure that we have all the types?
            foreach (var item in missingTypes)
            {
                if (!types.ContainsKey(item))
                {
                    ConsolePrinter.Write(ConsoleColor.Red, "Could not find type {0}", item);
                }
            }

            var jsonSerSettings = new JsonSerializerSettings();
            jsonSerSettings.TypeNameHandling = TypeNameHandling.All;
            jsonSerSettings.Formatting = Formatting.Indented;
            var jsonSer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSerSettings);

            using (StreamWriter sw = new StreamWriter("metadata.json"))
            {
                jsonSer.Serialize(sw, types);
            }
        }
    }
}
