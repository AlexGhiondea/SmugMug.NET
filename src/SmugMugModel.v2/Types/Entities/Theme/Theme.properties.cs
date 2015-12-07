// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class ThemeEntity : SmugMugEntity
    {
        public BaseColorEnum BaseColor {get; set;}
        public string Category {get; set;}
        public string Creator {get; set;}
        public string CreatorURL {get; set;}
        public DateTime LastUpdated {get; set;}
        public string Name {get; set;}
        public bool Stretchy {get; set;}
        public string Theme {get; set;}

    }
}
