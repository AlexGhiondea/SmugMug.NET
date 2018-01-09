// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class DecimalProperty : Property
    {
        public string Precision { get; set; }
        public string Scale { get; set; }
        public bool Signed { get; set; }

        public DecimalProperty()
        {
            Precision = Scale = string.Empty;
        }

        public DecimalProperty(JObject obj)
            : base(obj)
        {
            if (obj == null) { return; }

            Precision = obj.Property("PRECISION").ToObject<string>();
            Scale = obj.Property("SCALE").ToObject<string>();
            Signed = obj.Property("SIGNED").ToObject<bool>();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": Decimal ({0}, {1}), {2}", Precision, Scale, Signed ? "signed" : "unsigned");
        }
    }
}
