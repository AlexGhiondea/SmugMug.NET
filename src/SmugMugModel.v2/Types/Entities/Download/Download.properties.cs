// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class DownloadEntity : SmugMugEntity
    {
        public DateTime DateAdded {get; set;}
        public DateTime DateModified {get; set;}
        public string FileName {get; set;}
        public int Part {get; set;}
        public ImageStatusEnum Status {get; set;}

    }
}
