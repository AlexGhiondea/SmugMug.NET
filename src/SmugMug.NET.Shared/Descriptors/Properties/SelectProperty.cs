// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class SelectProperty : Property
    {
        public Limits OptionCountLimits { get; set; }

        public List<string> Options { get; set; }
        public SelectProperty()
        {
            Options = new List<string>();
        }

        public SelectProperty(JObject obj)
            : base(obj)
        {
            Options = new List<string>();

            if (obj == null)
            {
                return;
            }

            var min = obj.Property("MIN_COUNT").ToObject<string>();
            var max = obj.Property("MAX_COUNT").ToObject<string>();
            OptionCountLimits = new Limits(min, max);

            Options = new List<string>((obj.Property("OPTIONS").Value as JArray).Values().Select(x => x.ToString()));
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": Select {{{0}}}", string.Join(",", Options));
        }
    }
}
