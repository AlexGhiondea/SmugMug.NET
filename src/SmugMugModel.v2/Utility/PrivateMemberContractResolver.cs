// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace SmugMug.v2.Utility
{
    internal class PrivateMemberContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            var pi = member as PropertyInfo;

            if (pi == null)
                return property;

            if (pi.SetMethod != null)
                property.Writable = true;
            return property;
        }
    }
}
