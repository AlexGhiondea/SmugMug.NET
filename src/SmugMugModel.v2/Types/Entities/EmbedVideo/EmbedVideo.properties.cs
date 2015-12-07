// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class EmbedVideoEntity : SmugMugEntity
    {
        public string Compact {get; set;}
        public string EmbedSize1280 {get; set;}
        public string EmbedSize1920 {get; set;}
        public string EmbedSize320 {get; set;}
        public string EmbedSize640 {get; set;}
        public string EmbedSize960 {get; set;}
        public string Small {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}

    }
}
