// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class SizeEntity : SmugMugEntity
    {
        public int AlbumCount {get; set;}
        public int DynamicMediaCount {get; set;}
        public int DynamicMediaSize {get; set;}
        public int FolderCount {get; set;}
        public int MediaCount {get; set;}
        public int MediaSize {get; set;}
        public int PageCount {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}

    }
}
