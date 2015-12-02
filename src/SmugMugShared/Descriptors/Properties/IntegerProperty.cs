// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class IntegerProperty : Property
    {
        public Limits IntegerLimits { get; set; }
        public IntegerProperty(JObject obj)
            : base(obj)
        {
            if (obj == null) { return; }

            //TODO: This needs to be parsed as an int wrapper
            var min = obj.Property("MIN_VALUE").ToObject<string>();
            var max = obj.Property("MAX_VALUE").ToObject<string>();

            IntegerLimits = new Limits(min, max);
        }

        public override string ToString()
        {
            return base.ToString() + ": integer";
        }
    }
}
