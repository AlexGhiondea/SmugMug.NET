// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeCustomEntity : SmugMugEntity
    {
        public string Ext {get; set;}
        public int RequestedHeight {get; set;}
        public int RequestedWidth {get; set;}
        public string Url {get; set;}
        public bool Usable {get; set;}
        public bool Watermarked {get; set;}

    }
}
