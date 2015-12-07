// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class TemplateEntity : SmugMugEntity
    {
        public bool AjaxEnabled {get; set;}
        public bool CSSVer {get; set;}
        public bool Dark {get; set;}
        public string Filename {get; set;}
        public string Name {get; set;}
        public int Thumbs {get; set;}

    }
}
