using SmugMugModel.v2.Authentication;
using SmugMugModel.v2.Helpers;
using SmugMugTest.v2.Authentication;
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
using SmugMugTest.v2.PropertyDescriptors;


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



        static void Main(string[] args)
        {
            GetSmugMugSecrets();
            Debug.Assert(!oauthToken.Equals(OAuthToken.Invalid));

           

            string apiBase = "https://api.smugmug.com";

            //
            ObjectDescriptor entry = Explore("");

            Queue<ObjectDescriptor> nodes = new Queue<ObjectDescriptor>();
            nodes.Enqueue(entry);

            HashSet<string> alreadyVisited = new HashSet<string>();
            alreadyVisited.Add("");

            HashSet<ObjectDescriptor> objects = new HashSet<ObjectDescriptor>();

            HashSet<string> hs = new HashSet<string>();

            while (nodes.Count > 0)
            {
                ObjectDescriptor curr = nodes.Dequeue();
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
                            ObjectDescriptor newNode = Explore(apiBase + currMethod);

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

        private static ObjectDescriptor Explore(string uri)
        {
            HttpClient client = HttpClientHelpers.CreateHttpClient(oauthToken);

            var req = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;

            var od = ProcessData(req);

            return od;

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

        private static ObjectDescriptor ProcessData(string req)
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

            List<PropertyDescriptor> properties = new List<PropertyDescriptor>();

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
                            properties.Add(new SelectPropertyDescriptor(item));
                            break;
                        }
                    case "varchar":
                    case "text":
                        {
                            properties.Add(new StringPropertyDescriptor(item));
                            break;
                        }
                    case "uri":
                        {
                            properties.Add(new UriPropertyDescriptor(item));
                            break;
                        }
                    case "array":
                        {
                            properties.Add(new ArrayPropertyDescriptor(item));
                            break;
                        }
                    case "decimal":
                        {
                            properties.Add(new DecimalPropertyDescriptor(item));
                            break;
                        }
                    case "time":
                    case "date":
                    case "datetime":
                        {
                            properties.Add(new DateTimePropertyDescriptor(item));
                            break;
                        }
                    case "unixtimestamp":
                    case "timestamp":
                        {
                            properties.Add(new TimeStampPropertyDescriptor(item));
                            break;
                        }
                    case "boolean":
                        {
                            properties.Add(new BooleanPropertyDescriptor(item));
                            break;
                        }
                    case "integer":
                        {
                            properties.Add(new IntegerPropertyDescriptor(item));
                            break;
                        }
                    case "hash":
                        {
                            properties.Add(new HashPropertyDescriptor(item));
                            break;
                        }
                    default:
                        throw new InvalidDataException("I cannot do it -- type unknown ->>>   " + type);
                }
            }

            ObjectDescriptor od = new ObjectDescriptor();

            od.Properties = properties;

            var val = obj.Property("Response").Value as JObject;
            var name2 = val.Property("Locator").ToObject<string>();

            if (val.Property(name2) != null)
            {
                var uris = (val.Property(name2).Value as JObject).Property("Uris");
                if (uris != null)
                {
                    foreach (JProperty item in uris.Value)
                    {
                        MethodDescriptor md = new MethodDescriptor();
                        md.Uri = (item.Value as JObject).Property("Uri").Value.ToString();
                        md.ReturnType = (item.Value as JObject).Property("Locator").Value.ToString();

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
