// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace SmugMug.v2.Utility
{
    public static class JsonHelpers
    {
        public static string GetPayloadAsJson(List<KeyValuePair<string, object>> properties)
        {
            //NOTE: This uses reflection to get the values

            using (StringWriter writer = new StringWriter())
            using (JsonTextWriter jsonWrite = new JsonTextWriter(writer))
            {
                jsonWrite.WriteStartObject();

                foreach (var property in properties)
                {
                    // we only want to include the property if it was part of a patch or post request
                    jsonWrite.WritePropertyName(property.Key);
                    jsonWrite.WriteValue(property.Value);
                }

                jsonWrite.WriteEndObject();
                return writer.ToString();
            }
        }
    }
}
