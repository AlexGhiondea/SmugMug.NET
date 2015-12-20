// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ColorImageEntity : SmugMugEntity
    {
        private long _height;
        private string _uri;
        private string _uriDescription;
        private long _width;


        public long Height {
            get {
                return _height;
            }
            set {
                if (_height != value)
                {
                    _height = value;
                    NotifyPropertyValueChanged("Height", _height);
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
                    _uri = value;
                    NotifyPropertyValueChanged("Uri", _uri);
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
                    _uriDescription = value;
                    NotifyPropertyValueChanged("UriDescription", _uriDescription);
                }
            }
        }


        public long Width {
            get {
                return _width;
            }
            set {
                if (_width != value)
                {
                    _width = value;
                    NotifyPropertyValueChanged("Width", _width);
                }
            }
        }
    }
}
