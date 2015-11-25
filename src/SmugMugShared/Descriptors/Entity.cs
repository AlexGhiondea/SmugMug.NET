// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace SmugMug.Shared.Descriptors
{
    public class Entity
    {
        public string Name { get; set; }
        public List<Property> Properties { get; set; }

        public List<Method> Methods { get; set; }

        public Entity()
        {
            Methods = new List<Method>();
            Properties = new List<Property>();
        }
    }
}
