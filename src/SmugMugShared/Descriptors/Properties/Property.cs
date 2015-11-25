// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using SmugMug.Shared.Extensions;

namespace SmugMug.Shared.Descriptors
{
    public class Property
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Deprecated { get; set; }

        public Property(JObject obj)
        {
            Name = obj.GetValueAsString("Name");
            Description = obj.GetValueAsString("Description");
            Deprecated = obj.GetValueAsString("Deprecated");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
