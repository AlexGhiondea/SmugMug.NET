// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace SmugMug.v2.Utility
{
    public static class JsonHelpers
    {
        internal static JToken GetDataOrDefault(JObject obj)
        {
            const string ResponseString = "Response";

            JProperty response = obj.Property(ResponseString);
            if (response == null)
                return null;

            JObject responseValue = response.Value as JObject;
            if (responseValue == null)
                return null;

            JProperty locatorNode = responseValue.Property("Locator");

            if (locatorNode == null)
                return null;

            string entityName = locatorNode.Value.ToString();

            JProperty objectData = responseValue.Property(entityName);
            if (objectData == null)
                return null;

            return objectData.Value;
        }

        internal static string GetPayloadAsJson(List<KeyValuePair<string, object>> properties)
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

                    if (!property.Value.GetType().IsArray)
                    {
                        jsonWrite.WriteValue(property.Value);
                        continue;
                    }

                    // we are here if the property is an array.
                    WriteArrayValue(jsonWrite, property.Value);
                }

                jsonWrite.WriteEndObject();
                return writer.ToString();
            }
        }

        private static void WriteArrayValue(JsonTextWriter jsonWrite, object arrayValue)
        {
            jsonWrite.WriteStartArray();

            var array = arrayValue as Array;
            if (array != null)
            {
                foreach (var item in array)
                {
                    jsonWrite.WriteValue(item);
                }
            }

            jsonWrite.WriteEndArray();
        }
    }
}
