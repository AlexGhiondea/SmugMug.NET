// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using SmugMug.Shared.Extensions;

namespace SmugMug.Shared.Descriptors
{
    public class ArrayProperty : Property
    {
        public string ItemType { get; set; }
        public Limits ArrayLimits { get; set; }

        public ArrayProperty()
        {

        }

        public ArrayProperty(string name, string itemType)
            : base(name)
        {
            ItemType = itemType;
        }

        public ArrayProperty(JObject obj)
            : base(obj)
        {
            if (obj == null) { return; }

            ItemType = obj.GetValueAsString("ITEM_TYPE");

            var min = obj.Property("MIN_COUNT").ToObject<string>();
            var max = obj.Property("MAX_COUNT").ToObject<string>();
            ArrayLimits = new Limits(min, max);
        }

        public override string ToString()
        {
            return base.ToString() + ": Array (of" + ItemType + ")";
        }
    }
}
