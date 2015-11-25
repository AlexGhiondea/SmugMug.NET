using SmugMug.v2.Authentication;
using SmugMug.v2.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmugMugTest.v2;
using System.Text;
using System.Text.RegularExpressions;
using SmugMug.Shared.Descriptors;
using SmugMug.Shared.Extensions;

namespace SmugMugTest
{
    class Program
    {
        static OAuthToken oauthToken;

        /// <summary>
        /// If the secrets are in a file, get them from there. Otherwise, request them (apikey, secret) from the user
        /// </summary>
        private static void GetSmugMugSecrets()
        {
            if (!SmugMugSecretsAccess.TryReadSecretsFromFile(out oauthToken))
            {
                // Do we have the secret/apikey?
                Console.WriteLine("Please enter your API Key and press [Enter]:");
                string apiKey = Console.ReadLine();
                Console.WriteLine("Please enter your Application Secret and press [Enter]:");
                string secret = Console.ReadLine();

                oauthToken = SmugMugAuthorize.AuthorizeSmugMug(apiKey, secret, AuthenticationOptions.FullAccess);
                SmugMugSecretsAccess.SaveSecretsToFile(oauthToken);
            }

            Console.WriteLine("Using APIKey={0}", oauthToken.ApiKey);
            Console.WriteLine("Using AppSecret={0}", oauthToken.Secret);
            Console.WriteLine("Using token={0}", oauthToken.Token);
            Console.WriteLine("Using tokenSecret={0}", oauthToken.TokenSecret);
        }

        private static string CreateRegEx(string source)
        {
            int currPos = 0;
            StringBuilder sb = new StringBuilder();
            while (currPos < source.Length)
            {
                if (currPos > 1 && source[currPos] == ':' && source[currPos - 1] == '/')
                {
                    // this is the start of the identifier.
                    while (currPos < source.Length && source[currPos] != '/')
                        currPos++;

                    sb.Append("(\\S)*");
                    if (currPos != source.Length)
                        sb.Append("/");
                }
                else
                {
                    sb.Append(source[currPos]);
                }
                currPos++;
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            GetSmugMugSecrets();
            Debug.Assert(!oauthToken.Equals(OAuthToken.Invalid));

            string b = "https://api.smugmug.com";
            BaseUriFinder buf = new BaseUriFinder(oauthToken);
            var list = buf.GetBaseUris(b, "/api/v2");

            List<string> uriMatch = list.Select(x => CreateRegEx(x.Value)).ToList();
            uriMatch.AddRange(list.Select(x => CreateRegEx(x.Value) + "!(\\S)*").ToList()); // sometimes this is a better match

            Dictionary<string, Entity> objectData = new Dictionary<string, Entity>();

            list.Add("base", "/api/v2/user/ghiondea");

            Stack<KeyValuePair<string, string>> ToProcess = new Stack<KeyValuePair<string, string>>();
            foreach (var item in list)
            {
                ToProcess.Push(item);
            }

            HashSet<string> visited = new HashSet<string>();

            while (ToProcess.Count > 0)
            {
                var item = ToProcess.Pop();
                Console.WriteLine(b + item.Value + "?_pretty&_verbosity=3");
                Entity newNode = Explore(b + item.Value + "?_pretty&_verbosity=3");

                visited.Add(item.Value);

                if (newNode != null)
                {
                    var retType = newNode.Name == null ? item.Key : newNode.Name;

                    Console.WriteLine(retType);

                    if (newNode.Methods != null)
                    {
                        foreach (var method in newNode.Methods)
                        {
                            // we should reverse normalize the uri.
                            foreach (var uriRegEx in uriMatch)
                            {
                                if (Regex.IsMatch(method.Uri, uriRegEx))
                                {
                                    method.NormalizedUri = uriRegEx;
                                }
                            }

                            if (method.ReturnType == null)
                            {
                                Console.WriteLine("No known RetType! {0}", method.Uri);
                                continue;
                            }

                            if (visited.Contains(method.Uri))
                                continue;

                            ToProcess.Push(new KeyValuePair<string, string>(method.ReturnType, method.Uri));
                        }
                    }

                    Entity o;
                    if (objectData.TryGetValue(retType, out o))
                    {
                        // we need to merge them.
                        foreach (var p in newNode.Properties)
                        {
                            if (o.Properties.FirstOrDefault(x => x.Name == p.Name) == null)
                            {
                                o.Properties.Add(p);
                            }
                        }

                        // we need to merge them.
                        foreach (var m in newNode.Methods)
                        {
                            if (o.Methods.FirstOrDefault(x => x.Uri == m.Uri) == null)
                            {
                                o.Methods.Add(m);
                            }
                        }

                    }
                    else
                    {
                        objectData[retType] = newNode;
                    }
                }
            }

            return;

            string apiBase = "https://api.smugmug.com";

            //
            Entity entry = Explore("");

            Queue<Entity> nodes = new Queue<Entity>();
            nodes.Enqueue(entry);

            HashSet<string> alreadyVisited = new HashSet<string>();
            alreadyVisited.Add("");

            HashSet<Entity> objects = new HashSet<Entity>();

            HashSet<string> hs = new HashSet<string>();

            while (nodes.Count > 0)
            {
                Entity curr = nodes.Dequeue();
                if (curr.Methods == null)
                    continue;
                foreach (var item in curr.Methods)
                {
                    var currMethod = item.Uri + "?_responseLevel=Full&_pretty&_verbosity=3"; // (item.Value as JObject).Properties().Where(p => p.Name == "Uri").FirstOrDefault().Value.ToString();

                    if (!alreadyVisited.Contains(apiBase + currMethod))
                    {
                        objects.Add(curr);
                        alreadyVisited.Add(apiBase + currMethod);
                        Console.WriteLine(apiBase + currMethod);
                        try
                        {
                            Entity newNode = Explore(apiBase + currMethod);

                            if (newNode != null)
                            {
                                nodes.Enqueue(newNode);
                                Console.WriteLine(newNode.Name);
                            }
                            else
                            {

                            }
                        }
                        catch
                        {

                        }
                    }

                }
            }


            foreach (var item in objects)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static Entity Explore(string uri)
        {
            HttpClient client = HttpClientHelpers.CreateHttpClient(oauthToken);

            try {
                var req = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
                return ProcessData(req);
            }
            catch
            {
                return null;
            }
            

            return null;

            //string objName;
            //JProperty obj = GetObjectDataFromRequest(req, out objName) as JProperty;
            //if (obj == null)
            //    return default(SMObject);

            //Console.WriteLine(objName);

            //// get all the properties
            //IEnumerable<JProperty> props = null;
            //if (obj.Value is JObject)
            //{
            //    props = obj.Value.Children<JProperty>();
            //}
            //else if (obj.Value is JArray)
            //{
            //    if ((obj.Value as JArray).First != null)
            //    {
            //        props = (obj.Value as JArray).First.Children<JProperty>();
            //    }
            //}

            //if (props == null)
            //    return null;

            //var uris = props.Where(x => x.Name == "Uris").FirstOrDefault();
            //IEnumerable<JProperty> extraMethods = null;
            //if (uris != null)
            //{
            //    extraMethods = (uris.Value as JObject).Properties();
            //}

            //var onlyProps = props.Where(x => x.Name != "Uris");

            //var entry = new SMObject();
            //entry.Name = objName;
            //entry.Methods = extraMethods == null ? null : extraMethods.ToList();
            //entry.Properties = onlyProps == null ? null : onlyProps.ToList();

            //return entry;
        }

        private static Entity ProcessData(string req)
        {
            JObject obj = JObject.Parse(req);

            if (obj.Property("Options") == null)
                return null;

            var response = obj.Property("Options").Value as JObject;

            if (response == null)
                return null;

            if (response.Property("Output") == null)
                return null;

            var outputInfo = response.Property("Output").Value as JArray;

            List<Property> properties = new List<Property>();

            foreach (JObject item in outputInfo)
            {
                string name = item.Property("Name").Value.ToString();


                string type = item.GetValueAsString("Type");
                if (string.IsNullOrEmpty(type))
                {
                    type = "varchar";
                }

                switch (type.ToLower())
                {
                    case "select":
                        {
                            properties.Add(new SelectProperty(item));
                            break;
                        }
                    case "varchar":
                    case "text":
                        {
                            properties.Add(new StringProperty(item));
                            break;
                        }
                    case "uri":
                        {
                            properties.Add(new UriProperty(item));
                            break;
                        }
                    case "array":
                        {
                            properties.Add(new ArrayProperty(item));
                            break;
                        }
                    case "decimal":
                        {
                            properties.Add(new DecimalProperty(item));
                            break;
                        }
                    case "time":
                    case "date":
                    case "datetime":
                        {
                            properties.Add(new DateTimeProperty(item));
                            break;
                        }
                    case "unixtimestamp":
                    case "timestamp":
                        {
                            properties.Add(new TimeStampProperty(item));
                            break;
                        }
                    case "boolean":
                        {
                            properties.Add(new BooleanProperty(item));
                            break;
                        }
                    case "integer":
                        {
                            properties.Add(new IntegerProperty(item));
                            break;
                        }
                    case "hash":
                        {
                            properties.Add(new HashProperty(item));
                            break;
                        }
                    default:
                        throw new InvalidDataException("I cannot do it -- type unknown ->>>   " + type);
                }
            }

            Entity od = new Entity();

            od.Properties = properties;

            if (obj.Property("Response") == null)
                return od;

            var val = obj.Property("Response").Value as JObject;
            var name2 = val.Property("Locator").ToObject<string>();

            if (val.Property(name2) != null)
            {
                var uris = (val.Property(name2).Value as JObject).Property("Uris");
                if (uris != null)
                {
                    foreach (JProperty item in uris.Value)
                    {
                        Method md = new Method();
                        md.Uri = (item.Value as JObject).Property("Uri").Value.ToString();

                        if ((item.Value as JObject).Property("Locator") != null)
                        {
                            md.ReturnType = (item.Value as JObject).Property("Locator").Value.ToString();
                        }

                        od.Methods.Add(md);
                    }
                }
            }
            od.Name = name2;

            return od;

            //foreach (var prop in (response.Root as JObject).Properties())
            //{
            //    Console.WriteLine(prop.Name);
            //}

        }

        private class SMObject
        {
            public string Name;
            public List<JProperty> Properties;
            public List<JProperty> Methods;
        }

        private static JToken GetObjectDataFromRequest(string req, out string objectName)
        {
            JObject obj = JObject.Parse(req);

            // find the 'response' property

            var response = obj.Root.Children<JProperty>().Where(prop => prop.Name == "Response").FirstOrDefault();

            if (response == null)
            {
                objectName = null;
                return null;
                throw new InvalidDataException("Could not find Response!");
            }

            var responseChildren = response.Value.Children<JProperty>();
            var locator = responseChildren.Where(prop => prop.Name == "Locator").FirstOrDefault();

            if (locator == null)
            {
                objectName = null;
                return null;
            }
            objectName = locator.Value.ToString();
            return responseChildren.Where(prop => prop.Name == locator.Value.ToString()).FirstOrDefault();
        }
    }
}
