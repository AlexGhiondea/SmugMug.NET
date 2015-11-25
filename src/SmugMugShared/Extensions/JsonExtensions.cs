// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace SmugMug.Shared.Extensions
{
    public static class JsonExtensions
    {
        public static string GetValueAsString(this JObject obj, string name)
        {
            var prop = obj.Property(name);
            if (prop != null)
                return prop.Value.ToString();

            return string.Empty;
        }
    }
}
