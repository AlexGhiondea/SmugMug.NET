// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace SmugMugShared
{
    public static class RegExCreator
    {
        private static HashSet<string> s_specialUris = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        static RegExCreator()
        {
            s_specialUris.Add("/folder/user");
            s_specialUris.Add("/folder/id");
            s_specialUris.Add("/catalog/skutype/option");
            s_specialUris.Add("/catalog"); // this is last as this is the catch-all
            s_specialUris.Add("/highlight");
            s_specialUris.Add("/deleted");
        }
        private static string GetPrefix(string uri)
        {
            foreach (var specialUri in s_specialUris)
            {
                if (uri.StartsWith(specialUri))
                    return specialUri;
            }
            return string.Empty;
        }

        public static string FromUri(string baseUri, string uri, out int paramCount)
        {
            string temp = uri;
            string endpoint = string.Empty;
            string endpointParameter = string.Empty;
            string methodName = string.Empty;
            paramCount = 0;

            temp = temp.Replace(baseUri, "");

            string prefix = GetPrefix(temp);

            if (prefix.Length > 0)
                temp = temp.Substring(prefix.Length);


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

                    paramCount++;

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
                        paramCount++;
                    }
                    else if (v.Length == 3)
                    {
                        endpoint = endpoint + "/(*)/";
                        paramCount++;
                        endpointParameter = v[1] + "/(*)";
                        paramCount++;
                    }
                    else
                    {
                        endpoint = endpoint + "/" + v[0] + "/(*)";
                        paramCount++;
                        endpoint = endpoint + "/" + v[2];
                        endpointParameter = "/(*)";
                        paramCount++;
                    }

                }
                else
                {
                    endpointParameter = "/(*)";
                    paramCount++;
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
                    paramCount++;
                }
            }

            pos = temp.IndexOf('?');
            if (pos >= 0)
            {
                methodName = temp.Substring(0, pos);
                temp = temp.Replace(methodName + "?", "");
                methodName = "!" + methodName;
            }

            // we could have something like:
            // /folder/user/smugmuguser/albumName!parent
            // 

            string methodNorm = prefix + endpoint + endpointParameter + methodName;
            if (methodNorm.IndexOf("smugmuguser") > 0)
            {
                methodNorm = methodNorm.Replace("smugmuguser", "(*)");
                paramCount++;
            }


            return methodNorm;
        }

        public static string FromUri(string baseUri, string uri)
        {
            int dummy;
            return FromUri(baseUri, uri, out dummy);
        }
    }
}
