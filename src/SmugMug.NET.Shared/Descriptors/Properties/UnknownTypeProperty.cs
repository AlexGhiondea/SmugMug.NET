// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json.Linq;

namespace SmugMug.Shared.Descriptors
{
    public class UnknownTypeProperty : Property
    {
        public UnknownTypeProperty()
        {

        }

        public UnknownTypeProperty(string name)
            : base(name)
        {
        }

        public override string ToString()
        {
            return base.ToString() + ": unknown";
        }
    }
}
