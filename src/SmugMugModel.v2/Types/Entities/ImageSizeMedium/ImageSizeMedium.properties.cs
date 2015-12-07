// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeMediumEntity : SmugMugEntity
    {
        public decimal Bitrate {get; set;}
        public decimal Duration {get; set;}
        public string Ext {get; set;}
        public int Height {get; set;}
        public string MD5 {get; set;}
        public int Size {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public string Url {get; set;}
        public bool Usable {get; set;}
        public bool Watermarked {get; set;}
        public int Width {get; set;}

    }
}
