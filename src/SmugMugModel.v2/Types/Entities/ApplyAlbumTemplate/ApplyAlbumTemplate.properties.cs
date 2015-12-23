// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ApplyAlbumTemplateEntity : SmugMugEntity
    {
        private string _albumTemplateUri;
        private string _uri;
        private string _uriDescription;


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


        public string Uri {
            get {
                return _uri;
            }
            set {
                if (_uri != value)
                {
                    NotifyPropertyValueChanged("Uri", oldValue:_uri, newValue: value);
                    _uri = value;     
                }
            }
        }


        public string UriDescription {
            get {
                return _uriDescription;
            }
            set {
                if (_uriDescription != value)
                {
                    NotifyPropertyValueChanged("UriDescription", oldValue:_uriDescription, newValue: value);
                    _uriDescription = value;     
                }
            }
        }
    }
}
