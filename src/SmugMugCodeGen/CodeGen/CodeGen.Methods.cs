// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using System.Collections.Generic;
using System.Text;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        public static StringBuilder BuildMethods(List<Method> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/*");
            foreach (var item in list)
            {
                sb.AppendLine(string.Format("[{0}] -- {1}", item.ReturnType, item.Uri));
            }
            sb.AppendLine("*/");
            return sb;
        }
    }
}
