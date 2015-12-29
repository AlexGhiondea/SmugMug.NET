// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace SmugMug.v2.Utility
{
    public static class EnumExtensions
    {
        public static string GetEnumMemberValue(this Enum enumVal)
        {
            var enumType = enumVal.GetType();
            var memInfo = enumType.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);

            if (attributes.Length == 0)
                return enumVal.ToString();

            return (attributes[0] as EnumMemberAttribute).Value;
        }
    }
}
