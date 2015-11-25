// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMugShared
{
    public static class RegExCreator
    {
        public static string FromUri(string baseUri, string uri)
        {
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

            string methodNorm =  endpoint + endpointParameter + methodName;
#if DEBUG
            Console.WriteLine(uri);
            Console.WriteLine(methodNorm);
#endif
            return methodNorm;
        }
    }
}
