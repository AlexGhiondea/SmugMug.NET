// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        private static string GetPropertyType(Property prop)
        {
            if (prop is BooleanProperty)
                return "bool";
            if (prop is DecimalProperty)
                return "decimal";
            if (prop is FloatProperty)
                return "float";
            if (prop is IntegerProperty)
                return "int";
            if (prop is ArrayProperty)
                return GetArrayPropertyType(prop as ArrayProperty);
            if (prop is SelectProperty)
                return GetSelectPropertyType(prop as SelectProperty);
            if (prop is DateTimeProperty || prop is TimeStampProperty)
                return "DateTime";
            if (prop is StringProperty || prop is UriProperty || prop is HashProperty)
                return "string";

            throw new ArgumentException("Unknown property type");
        }

        private static string GetArrayPropertyType(ArrayProperty ap)
        {
            if (ap.ItemType == "Varchar")
                return "string[]";

            return ap.ItemType + "[]";
        }

        private static string GetSelectPropertyType(SelectProperty prop)
        {
            string typeName = GetEnumTypeName(prop);

            if (renameMap.ContainsKey(typeName))
                typeName = renameMap[typeName];

            return typeName + "Enum";
        }

        public static StringBuilder BuildProperties(IEnumerable<Property> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var prop in list)
            {
                string propName = Helpers.NormalizeString(prop.Name);
                string propType = GetPropertyType(prop);
                sb.AppendLine(string.Format(Constants.PropertyDefinition, propType, propName));
            }

            return sb;
        }
    }
}
