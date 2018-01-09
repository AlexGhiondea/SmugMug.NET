// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class Entity
    {
        public string Name { get; set; }
        public List<Property> Properties { get; set; }

        public List<Method> Methods { get; set; }


        public HashSet<string> AvailableHttpMethods { get; set; } // GET, POST, PATCH, etc

        public Dictionary<string, List<Property>> HttpMethodsAndParameters { get; set; }


        public string Deprecated { get; set; }

        public Entity()
        {
            Methods = new List<Method>();
            Properties = new List<Property>();
            AvailableHttpMethods = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            HttpMethodsAndParameters = new Dictionary<string, List<Property>>(StringComparer.OrdinalIgnoreCase);
        }

        public void MergeWith(Entity other)
        {
            if (string.IsNullOrEmpty(Deprecated) && !string.IsNullOrEmpty(other.Deprecated))
                this.Deprecated = other.Deprecated;
            else
                this.Deprecated += other.Deprecated;

            foreach (var meth in other.Methods)
            {
                if (Methods.FirstOrDefault(m => m.Uri == meth.Uri) == null)
                {
                    Methods.Add(meth);
                }
            }

            foreach (var prop in other.Properties)
            {
                var property = Properties.FirstOrDefault(p => p.Name == prop.Name);
                if (property == null)
                {
                    Properties.Add(prop);
                }
                else
                {
                    if (property is UnknownTypeProperty && !(prop is UnknownTypeProperty))
                    {
                        Properties.Remove(property);
                        Properties.Add(prop);
                    }
                    // we should try and merge the property info
                }
            }

            foreach (var method in other.AvailableHttpMethods)
            {
                AvailableHttpMethods.Add(method);
            }

            foreach (var methodsAndParams in other.HttpMethodsAndParameters)
            {
                List<Property> properties;
                if (HttpMethodsAndParameters.TryGetValue(methodsAndParams.Key, out properties))
                {
                    foreach (var newProp in methodsAndParams.Value)
                    {
                        var existingProperty = properties.FirstOrDefault(p => p.Name == newProp.Name);
                        if (existingProperty == null)
                        {
                            properties.Add(newProp);
                        }
                    }
                }
                else {
                    HttpMethodsAndParameters.Add(methodsAndParams.Key, methodsAndParams.Value);
                }
            }
        }
    }
}
