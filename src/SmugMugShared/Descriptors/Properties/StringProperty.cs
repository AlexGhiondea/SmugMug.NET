// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class StringProperty : Property
    {
        public Limits StringLimits { get; set; }
        public StringProperty(JObject obj)
            : base(obj)
        {
            if (obj == null)
            {
                return;
            }

            string min = string.Empty, max = string.Empty;
            if (obj.Property("MIN_CHARS") != null)
            {
                min = obj.Property("MIN_CHARS").ToObject<string>();
            }

            if (obj.Property("MIN_CHARS") != null)
            {
                max = obj.Property("MAX_CHARS").ToObject<string>();
            }
            StringLimits = new Limits(min, max);
        }

        public StringProperty(string name)
            : base(name)
        {
        }

        public StringProperty()
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": string";
        }
    }
}
