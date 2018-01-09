// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;
using System.Linq;
using System.Runtime.Serialization;

namespace SmugMug.v2.Utility
{
    public static class EnumExtensions
    {
        public static string GetEnumMemberValue(this Enum enumVal)
        {
            var enumType = enumVal.GetType();

            var memInfo = enumType.GetRuntimeProperty(enumVal.ToString()); // enumType.GetMember(enumVal.ToString());

            var attributes = memInfo.GetCustomAttributes(typeof(EnumMemberAttribute), false);

            if (!attributes.Any())
                return enumVal.ToString();

            return (attributes.First() as EnumMemberAttribute).Value;
        }
    }
}
