// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumImageShareUrisEntity : SmugMugEntity
    {
        private string _buyUri;
        private string _lightboxUri;
        private string _uri;
        private string _uriDescription;


        public string BuyUri {
            get {
                return _buyUri;
            }
            set {
                if (_buyUri != value)
                {
                    NotifyPropertyValueChanged("BuyUri", oldValue:_buyUri, newValue: value);
                    _buyUri = value;     
                }
            }
        }


        public string LightboxUri {
            get {
                return _lightboxUri;
            }
            set {
                if (_lightboxUri != value)
                {
                    NotifyPropertyValueChanged("LightboxUri", oldValue:_lightboxUri, newValue: value);
                    _lightboxUri = value;     
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
