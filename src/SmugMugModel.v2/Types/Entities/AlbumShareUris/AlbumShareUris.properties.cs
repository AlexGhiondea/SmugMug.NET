// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumShareUrisEntity : SmugMugEntity
    {
        public string SlideshowEmbedUri {get; set;}
        public string SlideshowFlashUri {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}

    }
}
