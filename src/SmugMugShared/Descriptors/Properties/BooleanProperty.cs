// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class BooleanProperty : Property
    {
        public BooleanProperty()
        {

        }

        public BooleanProperty(string name)
            : base(name)
        {

        }

        public BooleanProperty(JObject obj)
            : base(obj)
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": bool";
        }
    }
}
