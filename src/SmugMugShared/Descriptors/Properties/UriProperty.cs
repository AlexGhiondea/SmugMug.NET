// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using SmugMug.Shared.Extensions;

namespace SmugMug.Shared.Descriptors
{
    public class UriProperty : Property
    {
        public Limits UriLimits { get; set; }

        public UriProperty()
        {

        }

        public UriProperty(JObject obj)
            : base(obj)
        {
            var min = obj.GetValueAsString("MIN_LENGTH");
            var max = obj.GetValueAsString("MAX_LENGTH");

            UriLimits = new Limits(min, max);
        }

        public override string ToString()
        {
            return base.ToString() + ": Uri";
        }
    }
}
