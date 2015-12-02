// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using Newtonsoft.Json;
using SmugMug.Shared.Descriptors;
using System.Collections.Generic;
using System.IO;
namespace SmugMugCodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("Please provide the json file");
                return;
            }

            // The first argument is the path to the json file containing the
            string jsonFile = args[0];
            var jsonSerSettings = new JsonSerializerSettings();
            jsonSerSettings.TypeNameHandling = TypeNameHandling.All;

            Newtonsoft.Json.JsonSerializer jsonSer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSerSettings);

            using (StreamReader sr = new StreamReader(jsonFile))
            using (JsonReader jr = new JsonTextReader(sr))
            {
                var data = jsonSer.Deserialize<Dictionary<string, Entity>>(jr);
            }
        }
    }
}
