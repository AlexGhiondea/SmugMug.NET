// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using SmugMug.Shared.Descriptors;
using SmugMug.Shared.Extensions;
using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using SmugMugShared;
using SmugMugShared.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SmugMugMetadataRetriever
{
    public class ApiAnalyzer
    {
        OAuthToken _token;
        public ApiAnalyzer(OAuthToken oauthToken)
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

        public Dictionary<string, Entity> AnalyzeAPIs(Dictionary<string, string> uriStartingPoints, string baseUri)
        {
            Dictionary<string, Entity> result = new Dictionary<string, Entity>(StringComparer.OrdinalIgnoreCase);

            // Create the initial stack of the uris to analyze
            Stack<KeyValuePair<string, string>> stack = new Stack<KeyValuePair<string, string>>();
            stack.PushRange(uriStartingPoints);

            HashSet<string> alreadyVisited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            while (stack.Count > 0)
            {
                var uri = stack.Pop();

                ConsolePrinter.Write(ConsoleColor.DarkYellow, uri.Value);
                string normalized = RegExCreator.FromUri(baseUri, uri.Value);
                ConsolePrinter.Write(ConsoleColor.White, normalized);
                alreadyVisited.Add(normalized);


                ConsolePrinter.Write(ConsoleColor.Green, "Found {0} types", result.Count);
                ConsolePrinter.Write(ConsoleColor.Gray, "Processing {0} ...", uri.Value);

                var obj = Explore(uri.Value);
                if (obj == null)
                    continue;

                obj.Name = obj.Name ?? uri.Key;

                Entity current;
                if (result.TryGetValue(obj.Name ?? uri.Key, out current))
                {
                    // we need to merge the current object with a new one
                    current.MergeWith(obj);
                }
                else
                {
                    result[obj.Name] = obj;
                }

                foreach (var item in obj.Methods)
                {
                    string uriAddr = Constants.Addresses.SmugMug + item.Uri + Constants.RequestModifiers;

                    if (!alreadyVisited.Contains(RegExCreator.FromUri(baseUri, uriAddr)))
                    {
                        stack.Push(new KeyValuePair<string, string>(item.ReturnType, uriAddr));
                        ConsolePrinter.Write(ConsoleColor.Cyan, uriAddr);
                    }
                }
            }

            return result;
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

        private Entity Explore(string uri)
        {
            HttpClient client = HttpClientHelpers.CreateHttpClient(_token);

            try
            {
                var req = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
                return ProcessData(req);
            }
            catch { }


            return null;
        }

        private static Entity ProcessData(string req)
        {
            //TODO: Need to also 'guess' about the parameters based on the GET method... no other better way :(
            JObject obj = JObject.Parse(req);

            if (obj.Property("Options") == null)
            {
                return null;
            }

            Entity od = ProcessOutputEntry(obj);

            Entity mParams = ProcessParameterDetails(obj);

            od.MergeWith(mParams);

            var uriDict = DiscoverUris(obj);

            // Now process the Response in search of Uris
            if (obj.Property("Response") == null)
                return od;

            var valObj = obj.Property("Response").Value;
            var val = valObj as JObject;
            var name2 = string.Empty;
            if (val.Property("Locator") != null)
            {
                name2 = val.Property("Locator").ToObject<string>();
                od.Name = name2;
            }

            if (val.Property(name2) != null)
            {

                if ((val.Property(name2).Value as JObject) != null)
                {
                    var uris = (val.Property(name2).Value as JObject).Property("Uris");
                    if (uris != null)
                    {
                        foreach (JProperty item in uris.Value)
                        {
                            Method md = new Method();
                            md.Uri = (item.Value as JObject).GetValueAsString("Uri");

                            if ((item.Value as JObject).Property("Locator") != null)
                            {
                                md.ReturnType = (item.Value as JObject).Property("Locator").Value.ToString();
                            }
                            od.Methods.Add(md);
                        }
                    }
                }
                //else if ((val.Property(name2).Value as JArray) != null)
                //{
                //    var val2 = val.Property(name2).Value as JArray;

                //    foreach (JObject arrObj in val2)
                //    {
                //        var uris2 = arrObj.Property("Uris");
                //        if (uris2 != null)
                //        {
                //            foreach (JProperty item in uris2.Value)
                //            {
                //                Method md = new Method();
                //                md.Uri = (item.Value as JObject).Property("Uri").Value.ToString();
                //                md.ReturnType = (item.Value as JObject).Property("Locator").Value.ToString();

                //                od.Methods.Add(md);
                //            }
                //        }
                //    }
                //}

            }
            od.Name = name2;

            return od;

            //foreach (var prop in (response.Root as JObject).Properties())
            //{
            //    Console.WriteLine(prop.Name);
            //}

        }

        private static Entity ProcessParameterDetails(JObject obj)
        {
            Entity od = new Entity();
            if (obj.Property("Options") == null)
                return od;

            if ((obj.Property("Options").Value as JObject).Property("Parameters") == null)
                return od;

            var outputInfo = ((obj.Property("Options").Value as JObject).Property("Parameters").Value) as JObject;

            if (outputInfo.Property("PATCH") != null)
            {
                foreach (JObject item in outputInfo.Property("PATCH").Value as JArray)
                {
                    od.Properties.Add(Property.FromJObject(item));
                }
            }

            return od;
        }

        private static Dictionary<string, string> DiscoverUris(JObject obj)
        {
            // we need to traverse the Uris and find some stuff..
            if (obj.Property("Response") == null)
                return null;

            var Uris = (obj.Property("Response").Value as JObject).Property("Uris");

            if (Uris == null)
                return null;

            var discoveredUris = new Dictionary<string, string>();

            foreach (JProperty uri in Uris.Value)
            {
                var UriValue = (uri.Value as JObject).Property("Uri").Value;

                // If the property does not explain what the return type is (ie. locator) then assume the uri.Name
                string locator = uri.Name;
                if ((uri.Value as JObject).Property("Locator") != null)
                {
                    var LocatorValue = (uri.Value as JObject).Property("Locator").Value;
                    locator = LocatorValue.ToString();
                }
                discoveredUris.Add(locator, UriValue.ToString());
            }

            return discoveredUris;
        }

        private static Entity ProcessOutputEntry(JObject obj)
        {
            Entity od = new Entity();

            var response = obj.Property("Options").Value as JObject;

            if (response == null)
                return od;

            if (response.Property("Output") == null)
            {
                if (obj.Property("Response") == null)
                    return od;

                //do we have objects?
                var valObj2 = obj.Property("Response").Value;

                var val2 = valObj2 as JObject;
                string name3 = string.Empty;
                if (val2.Property("Locator") != null)
                {
                    name3 = val2.Property("Locator").ToObject<string>();
                }

                if (val2.Property("LocatorType") == null)
                {
                    return od;
                }
                var type2 = val2.Property("LocatorType").ToObject<string>();

                if (type2 == "Objects")
                {
                    if (val2.Property(name3) == null)
                    {
                        ConsolePrinter.Write(ConsoleColor.Yellow, "Empty response, expecting {0}", name3);
                        return od;
                    }
                    var arr = val2.Property(name3).Value as JArray;

                    Entity odd = new Entity();
                    foreach (var item in arr)
                    {
                        odd.Name = name3;
                        var methods = (item as JObject).Property("Uris");


                        if (methods.Value is JObject)
                        {
                            JObject o = methods.Value as JObject;

                            foreach (var entry in o)
                            {
                                var entryObj = (entry.Value as JObject);
                                var uri = entryObj.GetValueAsString("Uri");
                                var locator = entryObj.GetValueAsString("Locator");

                                odd.Methods.Add(new Method()
                                {
                                    ReturnType = locator,
                                    Uri = uri
                                });

                            }
                        }
                        else
                        {
                            throw new Exception();
                        }

                        break;
                    }
                    return odd;
                }
                return od;
            }

            var outputInfo = response.Property("Output").Value as JArray;

            // Process the properties
            List<Property> properties = new List<Property>();
            foreach (JObject item in outputInfo)
            {
                od.Properties.Add(Property.FromJObject(item));
            }

            return od;
        }

    }
}
