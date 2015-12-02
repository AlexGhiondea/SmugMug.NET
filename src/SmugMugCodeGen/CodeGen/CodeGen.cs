// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.Shared.Descriptors;
using System.Collections.Generic;
using System.Linq;

namespace SmugMugCodeGen
{
    public partial class CodeGen
    {
        public CodeGen(Dictionary<string, Entity> metadata)
        {
            // We need to figure out which types we would need to produce
            AnalyzeEnums(metadata.Values.ToList());
        }
    }
}
