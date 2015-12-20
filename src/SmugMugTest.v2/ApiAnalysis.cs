using Newtonsoft.Json.Linq;
using SmugMug.Shared.Descriptors;
using SmugMug.v2.Authentication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SmugMug.Shared.Extensions;
using SmugMug.v2.Helpers;

namespace SmugMugTest.v2
{
    public class ApiAnalysis
    {
        private OAuthToken oauthToken;

        public ApiAnalysis(OAuthToken token)
        {
            oauthToken = token;
        }

        internal static string GuessRegEx(string uri)
        {
            string baseUri = "https://api.smugmug.com/api/v2/";
            string temp = uri;
            string endpoint = string.Empty;
            string endpointParameter = string.Empty;
            string methodName = string.Empty;

            temp = temp.Replace(baseUri, "");

            // check for the ones that contain the ':id' code
            int ss = temp.IndexOf(':');
            if (ss >= 0)
            {
                while (ss >= 0)
                {
                    // if we have one that is already nice!
                    int le = temp.IndexOf('/', ss);
                    if (le == -1)
                    {
                        le = temp.IndexOf('!', ss);
                    }
                    if (le == -1)
                        le = temp.Length;

                    string val = temp.Substring(ss, le - ss);
                    uri = uri.Replace(val, "(*)");
                    temp = temp.Replace(val, "");

                    ss = temp.IndexOf(':', ss);
                }

                return uri;
            }


            int pos = temp.IndexOf('/');
            endpoint = temp.Substring(0, pos);
            temp = temp.Substring(endpoint.Length);


            pos = temp.IndexOf('!');
            if (pos >= 0)
            {
                endpointParameter = temp.Substring(0, pos);
                temp = temp.Replace(endpointParameter + "!", "");

                // the method is from ! to ? or from ! to end
                int que = temp.IndexOf('?');
                if (que == -1)
                    que = temp.Length;

                methodName = "!" + temp.Substring(0, que);
            }
            else
            {
                pos = temp.IndexOf('?');
                if (pos == -1)
                    pos = temp.Length;
                endpointParameter = temp.Substring(0, pos);
                temp = temp.Replace(endpointParameter + "?", "");
            }

            // if we have more '/' then well... more stuff
            if (endpointParameter != string.Empty)
            {
                if (endpointParameter.IndexOf('/', 1) >= 0)
                {
                    string[] v = endpointParameter.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                    if (v.Length == 2)
                    {
                        endpoint = endpoint + "/" + v[0];
                        endpointParameter = "/(*)";
                    }
                    else
                    {
                        endpoint = endpoint + "/(*)/";
                        endpointParameter = v[1] + "/(*)";
                    }

                }
                else
                {
                    endpointParameter = "/(*)";
                }
            }
            else
            {
                pos = temp.IndexOf('?');
                if (pos >= 0)
                {
                    endpointParameter = temp.Substring(0, pos);
                    temp = temp.Replace(endpointParameter + "?", "");

                    endpointParameter = "/(*)";
                }
            }

            pos = temp.IndexOf('?');
            if (pos >= 0)
            {
                methodName = temp.Substring(0, pos);
                temp = temp.Replace(methodName + "?", "");
                methodName = "!" + methodName;
            }

            string methodNorm = baseUri + endpoint + endpointParameter + methodName;
            //Console.WriteLine(uri);
            //Console.WriteLine(methodNorm);
            return methodNorm;
        }

        public Dictionary<string, Entity> Analyze(Dictionary<string, string> uriStartingPoints)
        {
            Dictionary<string, Entity> result = new Dictionary<string, Entity>(StringComparer.OrdinalIgnoreCase);

            Stack<KeyValuePair<string, string>> stack = new Stack<KeyValuePair<string, string>>();
            foreach (var item in uriStartingPoints)
            {
                stack.Push(item);
            }
            HashSet<string> alreadyVisited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            while (stack.Count > 0)
            {
                var uri = stack.Pop();

                Print(ConsoleColor.DarkYellow, uri.Value);
                string normalized = GuessRegEx(uri.Value);
                Print(ConsoleColor.White, normalized);
                alreadyVisited.Add(normalized);



                Print(ConsoleColor.Green, "Found {0} types", result.Count);
                Print(ConsoleColor.Gray, "Processing {0} ...", uri.Value);

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
                    string uriAddr = "https://api.smugmug.com" + item.Uri + "?_pretty&_verbosity=3";

                    if (!alreadyVisited.Contains(GuessRegEx(uriAddr)))
                    {
                        stack.Push(new KeyValuePair<string, string>(item.ReturnType, uriAddr));
                        Print(ConsoleColor.Cyan, uriAddr);
                    }
                }
            }

            return result;
        }

        private static void Print(ConsoleColor color, string message, params object[] args)
        {
            var curColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.WriteLine(message, args);

            Console.ForegroundColor = curColor;
        }

        private Entity Explore(string uri)
        {
            HttpClient client = HttpClientHelpers.CreateHttpClient(oauthToken);

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
            var deprecated = ((obj.Property("Options").Value as JObject)).GetValueAsString("Deprecated");

            if (!string.IsNullOrEmpty(deprecated))
            {
                od.Deprecated = deprecated;
            }

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
                        Print(ConsoleColor.Yellow, "Empty response, expecting {0}", name3);
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
