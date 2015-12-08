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
        private static Options _options;

        private static void PrintUsage()
        {
            ConsolePrinter.Write(ConsoleColor.White, "Usage:");
            ConsolePrinter.Write(ConsoleColor.Cyan, "smugmugcodegen.exe <outputFolder> [<metadataFiles>] ");
        }

        static void Main(string[] args)
        {
            // The usage of this tool is going to be:
            // smugmugcodegen.exe <outputFolder> [<metadataFiles>] 
            if (args.Length < 2)
            {
                PrintUsage();
                Environment.Exit(-1);
            }

            //get the output directory.
            _options = new Options(args);

            Dictionary<string, Entity> metadata = LoadMetadataFromFile(_options.InputFiles);

            // Make sure the output directories exist
            if (Helpers.TryCreateDirectory(_options.OutputDir) == false)
                Environment.Exit(-2);
            if (Helpers.TryCreateDirectory(_options.OutputDirEnums) == false)
                Environment.Exit(-2);

            CodeGen cg = new CodeGen(metadata);

            WriteClasses(metadata);

            WriteEnums();
        }

        private static void WriteEnums()
        {
            Dictionary<string, string> enumTypeDefs = CodeGen.BuildEnums();

            foreach (var item in enumTypeDefs)
            {
                File.WriteAllText(Path.Combine(_options.OutputDirEnums, item.Key + "Enum.cs"), item.Value);
                ConsolePrinter.Write(ConsoleColor.Green, "Generated enum {0}", item.Key);
            }
            ConsolePrinter.Write(ConsoleColor.White, "Generated {0} enums", enumTypeDefs.Count);
        }

        private static void WriteClasses(Dictionary<string, Entity> metadata)
        {
            foreach (var item in metadata)
            {
                StringBuilder properties = CodeGen.BuildProperties(item.Value.Properties.OrderBy(p => p.Name));
                StringBuilder methods = CodeGen.BuildMethods(item.Value.Methods);
                string className = Helpers.NormalizeString(item.Value.Name);

                string objectDirName = Path.Combine(_options.OutputDir, className);
                Directory.CreateDirectory(objectDirName);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(Constants.ClassDefinition, className, properties);
                File.WriteAllText(Path.Combine(objectDirName, item.Key + ".properties.cs"), sb.ToString());

                sb = new StringBuilder();
                sb.AppendFormat(Constants.ClassDefinition, className, methods);
                File.WriteAllText(Path.Combine(objectDirName, item.Key + ".methods.cs"), sb.ToString());

                ConsolePrinter.Write(ConsoleColor.Green, "Generated class {0}", item.Key);
            }
            ConsolePrinter.Write(ConsoleColor.White, "Generated {0} classes", metadata.Count);
        }

        private static Dictionary<string, Entity> LoadMetadataFromFile(string[] files)
        {
            Dictionary<string, Entity> data = null;

            foreach (var file in files)
            {
                if (!File.Exists(file))
                {
                    ConsolePrinter.Write(ConsoleColor.Yellow, "Cannot find file {0}. Skipping...", file);
                    continue;
                }

                try
                {
                    var jsonSerSettings = new JsonSerializerSettings();
                    jsonSerSettings.TypeNameHandling = TypeNameHandling.All;
                    Newtonsoft.Json.JsonSerializer jsonSer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSerSettings);

                    using (StreamReader sr = new StreamReader(file))
                    using (JsonReader jr = new JsonTextReader(sr))
                    {
                        ConsolePrinter.Write(ConsoleColor.White, "Loading metadata from file {0}", file);
                        var currentData = jsonSer.Deserialize<Dictionary<string, Entity>>(jr);

                        // If this is the first file, nothing to merge.
                        if (data == null)
                        {
                            data = currentData;
                            continue;
                        }

                        // we need to merge the 2 entities.
                        MergeMetadataInfo(data, currentData);
                    }
                }
                catch (Exception e)
                {
                    ConsolePrinter.Write(ConsoleColor.Red, "Error processing file {0} ({1}). Skipping.", file, e.Message);
                }
            }

            return data;
        }

        private static void MergeMetadataInfo(Dictionary<string, Entity> current, Dictionary<string, Entity> other)
        {
            foreach (var key in other.Keys)
            {
                if (current.ContainsKey(key))
                {
                    // We need to merge the 2 
                    var currentEntity = current[key];
                    var otherEntity = other[key];

                    currentEntity.MergeWith(otherEntity);
                }
                else
                {
                    // this is a new thing in other, and not in current. 
                    // Add it to current.
                    current.Add(key, other[key]);
                }
            }
        }
    }
}
