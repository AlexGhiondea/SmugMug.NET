// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class WatermarkEntity : SmugMugEntity
    {
        public int Dissolve {get; set;}
        public int ImageID {get; set;}
        public string ImageKey {get; set;}
        public string Name {get; set;}
        public PinnedEnum Pinned {get; set;}
        public SmallestSizeEnum SmallestSize {get; set;}
        public bool Thumbs {get; set;}
        public int WatermarkID {get; set;}

    }
}
