// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class PrintmarkEntity : SmugMugEntity
    {
        public int Dissolve {get; set;}
        public int Gap {get; set;}
        public int ImageID {get; set;}
        public string ImageKey {get; set;}
        public string ImageUri {get; set;}
        public string Location {get; set;}
        public string Name {get; set;}
        public int PrintmarkID {get; set;}
        public int Scale {get; set;}

    }
}
