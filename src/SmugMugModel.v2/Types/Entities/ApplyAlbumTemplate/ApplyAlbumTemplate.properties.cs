// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ApplyAlbumTemplateEntity : SmugMugEntity
    {
        private string _albumTemplateUri;


        public string AlbumTemplateUri {
            get {
                return _albumTemplateUri;
            }
            set {
                if (_albumTemplateUri != value)
                {
                    NotifyPropertyValueChanged("AlbumTemplateUri", oldValue:_albumTemplateUri, newValue: value);
                    _albumTemplateUri = value;     
                }
            }
        }
    }
}
