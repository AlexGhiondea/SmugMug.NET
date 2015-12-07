// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class PageEntity : SmugMugEntity
    {
        public bool AutoRename {get; set;}
        public DateTime DateAdded {get; set;}
        public DateTime DateModified {get; set;}
        public string HighlightImageUri {get; set;}
        public string Name {get; set;}
        public string Password {get; set;}
        public string PasswordHint {get; set;}
        public PrivacyEnum Privacy {get; set;}
        public SecurityTypeEnum SecurityType {get; set;}
        public string UrlName {get; set;}
        public string UrlPath {get; set;}

    }
}
