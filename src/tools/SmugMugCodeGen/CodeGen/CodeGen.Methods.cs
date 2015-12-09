// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using SmugMugShared;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        public static StringBuilder BuildMethods(List<Method> list)
        {
            StringBuilder sb = new StringBuilder();

            HashSet<string> methodMap = new HashSet<string>();

            foreach (var item in list)
            {
                string returnType, methodName, uri, returnCode;

                returnType = "void"; // this is the default
                if (!string.IsNullOrEmpty(item.ReturnType))
                    returnType = Helpers.NormalizeString(item.ReturnType) + "Entity";

                uri = RegExCreator.FromUri(SmugMugShared.Constants.Addresses.SmugMugApi, SmugMugShared.Constants.Addresses.SmugMug + item.Uri);
                methodName = Helpers.NormalizeString(uri, '!', '(', ')', '*');

                returnCode = returnType == "void" ? string.Empty : string.Format("return default({0});", returnType);

                string key = returnType + " " + methodName;
                if (methodMap.Contains(key))
                {
                    continue;
                }

                methodMap.Add(key);
                sb.AppendLine(string.Format(Constants.MethodDefinition, returnType, methodName, uri, returnCode));
            }
            return sb;
        }
    }
}
