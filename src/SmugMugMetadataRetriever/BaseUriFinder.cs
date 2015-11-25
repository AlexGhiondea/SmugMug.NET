// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SmugMugMetadataRetriever
{
    public class UriFinder
    {
        OAuthToken _token;
        public UriFinder(OAuthToken oauthToken)
        {
            _token = oauthToken;
        }

        public Dictionary<string, string> GetBaseUris(string baseAddress, string method)
        {
            Stack<KeyValuePair<string, string>> UrisToCheck = new Stack<KeyValuePair<string, string>>();

            Dictionary<string, string> visited = new Dictionary<string, string>();
            UrisToCheck.Push(new KeyValuePair<string, string>("", method));

            using (HttpClient client = HttpClientHelpers.CreateHttpClient(_token))
            {
                while (UrisToCheck.Count > 0)
                {
                    var curr = UrisToCheck.Pop();

                    if (curr.Value.IndexOf(':', 6) > 0)
                    {
                        visited.Add(curr.Key, curr.Value);
                    }

                    string uri = baseAddress + curr.Value;
                    Console.WriteLine("Processing: " + uri);
                    var result = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;

                    var discUris = DiscoverUris(result);

                    if (discUris == null)
                        continue;

                    foreach (var item in discUris)
                    {
                        UrisToCheck.Push(item);
                    }
                }
            }

            return visited;
        }

        private static Dictionary<string, string> DiscoverUris(string req)
        {
            // we need to traverse the Uris and find some stuff..
            JObject obj = JObject.Parse(req);

            if (obj.Property("Response") == null)
                return null;

            var Uris = (obj.Property("Response").Value as JObject).Property("Uris");

            if (Uris == null)
                return null;

            var discoveredUris = new Dictionary<string, string>();

            foreach (JProperty uri in Uris.Value)
            {
                var UriValue = (uri.Value as JObject).Property("Uri").Value;
                discoveredUris.Add(uri.Name, UriValue.ToString());
            }

            return discoveredUris;
        }
    }
}
