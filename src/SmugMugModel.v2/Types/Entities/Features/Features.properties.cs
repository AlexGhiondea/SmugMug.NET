// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class FeaturesEntity : SmugMugEntity
    {
        public bool Backprinting {get; set;}
        public bool CustomPackaging {get; set;}
        public bool GrantAccess {get; set;}
        public bool Printmarks {get; set;}
        public bool RightClickProtection {get; set;}
        public bool Sales {get; set;}
        public bool Sharpening {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public bool Video {get; set;}
        public bool Watermarks {get; set;}

    }
}
