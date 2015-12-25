// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        //TODO: This can probably be updated to 
        // Dictionary<string, List<HashSet<string>>>>
        // that way we don't have to do look-ups for the typename traversing the dictionary multiple times
        static Dictionary<string, Dictionary<string, string>> mapTypeToMembers = new Dictionary<string, Dictionary<string, string>>();

        //TODO: We need to be able to rename types
        // for now, hardcode it...
        static Dictionary<string, string> renameMap = new Dictionary<string, string>()
        {
            {"Status", "CommentStatus"},
            {"Status1", "ImageStatus"}
        };

        private static string GetEnumTypeName(SelectProperty prop)
        {
            string typeName = Helpers.NormalizeString(prop.Name);

            // find the enums that start with the same name
            var listOfEnum = mapTypeToMembers.Keys
                .Where(k => k.StartsWith(typeName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (listOfEnum.Count() == 1)
                return listOfEnum.First();

            // Creating the current props so that we don't re-run the normalize multiple times.
            Dictionary<string, string> props = prop.Options.ToDictionary
                (
                    key => Helpers.NormalizeString(key),
                    value => value
                );

            //find the enum that contains all the required values
            foreach (var item in listOfEnum)
            {
                // get the list of enum values to look for
                Dictionary<string, string> toSearchFor = new Dictionary<string, string>(props);
                foreach (var looking in mapTypeToMembers[item])
                {
                    //todo  == can we just use looking.value?
                    toSearchFor.Remove(Helpers.NormalizeString(looking.Key));
                }
                if (toSearchFor.Count == 0)
                    return item;
            }

            // We should not get here
            throw new InvalidOperationException(string.Format("Could not find the enum {0}", typeName));
        }

        private void AnalyzeEnums(IEnumerable<Entity> list)
        {
            // get all the properties of the SelectProperty type
            var selectProps = list.SelectMany(p => p.Properties.Where(pp => pp is SelectProperty))
                .Cast<SelectProperty>()
                .OrderBy(prop => prop.Name)
                .ThenBy(prop => prop.Options.Count)
                .ToList();

            foreach (SelectProperty prop in selectProps)
            {
                string typeName = Helpers.NormalizeString(prop.Name);

                // TODO: A different data structure might help
                // find the enums that start with the same name
                var listOfEnum = mapTypeToMembers.Keys
                    .Where(k => k.StartsWith(typeName, StringComparison.OrdinalIgnoreCase));

                bool found = false;
                Dictionary<string, string> NormalizedToActualMembers = new Dictionary<string, string>();

                Dictionary<string, string> existingMembers;
                foreach (var item in listOfEnum)
                {
                    existingMembers = mapTypeToMembers[item];

                    bool overlap = false;
                    foreach (var opt in prop.Options)
                    {
                        if (existingMembers.ContainsKey(Helpers.NormalizeString(opt)))
                        {
                            overlap = true;
                            break;
                        }
                    }

                    if (overlap)
                    {
                        // let's merge the two
                        foreach (var opt in prop.Options)
                        {
                            existingMembers[Helpers.NormalizeString(opt)] = opt;
                        }
                        found = true;
                    }
                }

                if (!found)
                {
                    existingMembers = new Dictionary<string, string>();
                    foreach (var item in prop.Options)
                    {
                        existingMembers.Add(Helpers.NormalizeString(item), item);
                    }

                    // Do we have a conflict?
                    int conflict = 1;
                    while (mapTypeToMembers.ContainsKey(typeName))
                        typeName += conflict.ToString();

                    mapTypeToMembers.Add(typeName, existingMembers);
                }
            }
        }

        internal static string BuildMethodReturningParametersToSendInRequest(Entity value)
        {
            StringBuilder sb = new StringBuilder();
            
            if (value.HttpMethodsAndParameters.ContainsKey("patch"))
            {
                string patchParams = string.Join(",", value.HttpMethodsAndParameters["patch"].Select(p => string.Format("\"{0}\"", p.Name)));
                sb.AppendFormat(Constants.MethodReturnsParameters, "Patch", patchParams);
            }
            if (value.HttpMethodsAndParameters.ContainsKey("post"))
            {
                string patchParams = string.Join(", ", value.HttpMethodsAndParameters["post"].Select(p => string.Format("\"{0}\"", p.Name)));
                sb.AppendFormat(Constants.MethodReturnsParameters, "Post", patchParams);
            }

            return sb.ToString();
        }

        public static Dictionary<string, string> BuildEnums()
        {
            Dictionary<string, string> enumTypeDefs = new Dictionary<string, string>();

            foreach (var item in mapTypeToMembers)
            {
                string typeName = item.Key;
                if (renameMap.ContainsKey(typeName))
                    typeName = renameMap[typeName];

                // we need to generate code that allows JSON.NET to deserialize the enum that comes in as text
                // [EnumMember("value with spaces")]

                bool hasGeneratedAttribute = false;
                StringBuilder enumValues = new StringBuilder();
                foreach (var enumValue in item.Value)
                {
                    if (enumValue.Key != enumValue.Value)
                    {
                        // we have to emit the attribute
                        enumValues.AppendLine(string.Format("        [EnumMember(Value=\"{0}\")]", enumValue.Value));
                        enumValues.AppendLine(string.Format("        {0},", enumValue.Key));
                        hasGeneratedAttribute = true;
                    }
                    else
                    {
                        enumValues.AppendLine(string.Format("        {0},", enumValue.Key));
                    }
                }

                // We need to remove the last 3 characters (comma,newline,linefeed)
                enumValues.Remove(enumValues.Length - 3, 3);
                string usingStatements = hasGeneratedAttribute ? "using System.Runtime.Serialization;" : string.Empty;

                string enumCode = string.Format(Constants.EnumDefinition, usingStatements, typeName + "Enum", enumValues.ToString());
                enumTypeDefs.Add(typeName, enumCode);
            }



            return enumTypeDefs;
        }
    }
}
