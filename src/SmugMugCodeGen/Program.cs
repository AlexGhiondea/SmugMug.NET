// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using SmugMug.Shared.Descriptors;
using SmugMugShared.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            Dictionary<string, Entity> metadata = LoadMetadataFromFile(jsonFile);

            CodeGen cg = new CodeGen(metadata);

            foreach (var item in metadata)
            {
                StringBuilder sb = new StringBuilder();

                StringBuilder properties = CodeGen.BuildProperties(item.Value.Properties.OrderBy(p => p.Name));
                StringBuilder methods = CodeGen.BuildMethods(item.Value.Methods);
                string className = Helpers.NormalizeString(item.Value.Name);

                sb.AppendFormat(Constants.ClassDefinition, className, properties, methods);

                File.WriteAllText(item.Key + ".cs", sb.ToString());

                ConsolePrinter.Write(ConsoleColor.Green, "Generated class {0}", item.Key);
            }
            ConsolePrinter.Write(ConsoleColor.White, "Generated {0} classes", metadata.Count);

            Dictionary<string, string> enumTypeDefs = CodeGen.BuildEnums();

            foreach (var item in enumTypeDefs)
            {
                File.WriteAllText(item.Key + "Enum.cs", item.Value);
                ConsolePrinter.Write(ConsoleColor.Green, "Generated enum {0}", item.Key);
            }
            ConsolePrinter.Write(ConsoleColor.White, "Generated {0} enums", enumTypeDefs.Count);
        }

        private static Dictionary<string, Entity> LoadMetadataFromFile(string jsonFile)
        {
            var jsonSerSettings = new JsonSerializerSettings();
            jsonSerSettings.TypeNameHandling = TypeNameHandling.All;
            Newtonsoft.Json.JsonSerializer jsonSer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSerSettings);

            using (StreamReader sr = new StreamReader(jsonFile))
            using (JsonReader jr = new JsonTextReader(sr))
            {
                ConsolePrinter.Write(ConsoleColor.White, "Loading metadata from file");
                var data = jsonSer.Deserialize<Dictionary<string, Entity>>(jr);

                return data;
            }
        }
    }
}
