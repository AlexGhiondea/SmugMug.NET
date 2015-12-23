// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using SmugMugShared;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        public static StringBuilder BuildManualMethods(List<Method> unsortedList)
        {
            StringBuilder sb = new StringBuilder();

            var list = unsortedList.OrderBy(m => m.Uri);

            HashSet<string> methodMap = new HashSet<string>();

            foreach (var item in list)
            {
                string returnType, methodName, returnCode = string.Empty, uri;

                returnType = Constants.VoidMethodReturnType; // this is the default
                if (!string.IsNullOrEmpty(item.ReturnType))
                {
                    returnType = item.ReturnType;

                    if (returnType.EndsWith("[]"))
                        returnType = returnType.Replace("[]", "");

                    returnType = Helpers.NormalizeString(returnType) + "Entity";

                    if (item.ReturnType.EndsWith("[]"))
                        returnType += "[]";
                }

                int paramCount;
                uri = RegExCreator.FromUri(SmugMug.v2.Constants.Addresses.SmugMugApi, SmugMug.v2.Constants.Addresses.SmugMug + item.Uri, out paramCount);
                methodName = Helpers.NormalizeString(uri, '!', '(', ')', '*');
                //   parameters = GenerateParams(paramCount);

                StringBuilder parameterBuilder = new StringBuilder();
                for (int i = 0; i < paramCount; i++)
                {
                    parameterBuilder.Append("string.Empty");
                    if (i != paramCount - 1)
                        parameterBuilder.Append(", ");
                }

                if (returnType != Constants.VoidMethodReturnType)
                {
                    returnCode = "return ";
                }

                returnCode += string.Format("await {0}({1});", methodName, parameterBuilder.ToString());

                methodName = "Fixup_" + methodName;
                string key = returnType + " " + methodName;
                if (methodMap.Contains(key))
                {
                    continue;
                }

                methodMap.Add(key);

                string methodDefinitionFormat = returnType == Constants.VoidMethodReturnType ?
                                                    Constants.VoidMethodDefinition :
                                                    Constants.MethodDefinition;

                sb.AppendLine(string.Format(methodDefinitionFormat,
                    /*return type*/returnType,
                    /*method name*/methodName,
                    /*parameters*/ string.Empty,
                    /*comment*/uri,
                    /*return statement*/returnCode));
            }
            return sb;
        }

        public static StringBuilder BuildMethods(List<Method> unsortedList)
        {
            StringBuilder sb = new StringBuilder();

            var list = unsortedList.OrderBy(m => m.Uri);

            HashSet<string> methodMap = new HashSet<string>();

            foreach (var item in list)
            {
                string returnType, methodName, uri, returnCode, parameters;

                returnType = Constants.VoidMethodReturnType; // this is the default
                if (!string.IsNullOrEmpty(item.ReturnType))
                {
                    returnType = item.ReturnType;

                    if (returnType.EndsWith("[]"))
                        returnType = returnType.Replace("[]", "");

                    returnType = Helpers.NormalizeString(returnType) + "Entity";

                    if (item.ReturnType.EndsWith("[]"))
                        returnType += "[]";
                }

                int paramCount;
                uri = RegExCreator.FromUri(SmugMug.v2.Constants.Addresses.SmugMugApi, SmugMug.v2.Constants.Addresses.SmugMug + item.Uri, out paramCount);
                methodName = Helpers.NormalizeString(uri, '!', '(', ')', '*');
                parameters = GenerateParams(paramCount);

                returnCode = GenerateMethodCall(uri, returnType, paramCount);

                string key = returnType + " " + methodName;
                if (methodMap.Contains(key))
                {
                    continue;
                }

                methodMap.Add(key);

                string methodDefinitionFormat = returnType == Constants.VoidMethodReturnType ?
                                                    Constants.VoidMethodDefinition :
                                                    Constants.MethodDefinition;

                /*public async Task<{returnType}> {methodName} ({parameters})
                {
                    // {comment}
                            * 
                    {returnCode}
                }*/

                sb.AppendLine(string.Format(methodDefinitionFormat,
                    /*return type*/returnType,
                    /*method name*/methodName,
                    /*parameters*/parameters,
                    /*comment*/uri,
                    /*return statement*/returnCode));
            }
            return sb;
        }

        private static readonly string[] UriParameterDelimiter = new string[] { "(*)" };
        private static string GenerateMethodCall(string uri, string returnType, int parameterCount)
        {
            string methodCall, awaitStatement;

            if (returnType == Constants.VoidMethodReturnType)
            {
                methodCall = "GetRequestAsync";
                awaitStatement = "await {0}(requestUri);";
            }
            else
            {
                methodCall = returnType.TrimEnd().EndsWith("[]") ?
                                "RetrieveEntityArrayAsync" :
                                "RetrieveEntityAsync";
                awaitStatement = "await {0}<{1}>(requestUri);";
            }

            // we need to first reconstruct the uri to take into account the parameters.

            StringBuilder sb = new StringBuilder();

            // the code that puts the uri together with the parameters.
            sb.AppendLine(CreateRequestUriWithParameters(uri, parameterCount));
            sb.AppendLine();
            sb.Append("            ");
            if (returnType != "Task")
                sb.Append("return ");


            sb.AppendFormat(awaitStatement, methodCall, returnType.Replace("[]", ""));
            return sb.ToString();
        }

        private static string CreateRequestUriWithParameters(string uri, int parameterCount)
        {
            StringBuilder requestUri = new StringBuilder();
            requestUri.Append("string requestUri = string.Format(\"{0}");
            string[] parts = uri.Split(UriParameterDelimiter, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                requestUri.Append(parts[i]);

                if (!parts[i].StartsWith("!"))
                {
                    // the part that starts with '!' does not accept parameters.
                    requestUri.Append("{");
                    requestUri.Append(i + 1);
                    requestUri.Append("}");
                }
            }
            requestUri.Append("\", "); // close format string;
            requestUri.Append("SmugMug.v2.Constants.Addresses.SmugMugApi, ");
            for (int i = 0; i < parameterCount; i++)
            {
                requestUri.Append(Constants.ParameterNameBase);
                requestUri.Append(i + 1);
                if (i != parameterCount - 1)
                    requestUri.Append(",");
            }

            requestUri.Append(");"); // close string.format
            return requestUri.ToString();
        }

        private static string GenerateParams(int count)
        {
            if (count == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.AppendFormat("string {0}{1}", Constants.ParameterNameBase, i + 1);
                if (i + 1 < count)
                    sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
