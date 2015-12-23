// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {
        private string _ext;
        private long _height;
        private long _size;
        private string _uri;
        private string _uriDescription;
        private string _url;
        private bool _usable;
        private bool _watermarked;
        private long _width;


        public string Ext {
            get {
                return _ext;
            }
            set {
                if (_ext != value)
                {
                    NotifyPropertyValueChanged("Ext", oldValue:_ext, newValue: value);
                    _ext = value;     
                }
            }
        }


        public long Height {
            get {
                return _height;
            }
            set {
                if (_height != value)
                {
                    NotifyPropertyValueChanged("Height", oldValue:_height, newValue: value);
                    _height = value;     
                }
            }
        }


        public long Size {
            get {
                return _size;
            }
            set {
                if (_size != value)
                {
                    NotifyPropertyValueChanged("Size", oldValue:_size, newValue: value);
                    _size = value;     
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


        public string Url {
            get {
                return _url;
            }
            set {
                if (_url != value)
                {
                    NotifyPropertyValueChanged("Url", oldValue:_url, newValue: value);
                    _url = value;     
                }
            }
        }


        public bool Usable {
            get {
                return _usable;
            }
            set {
                if (_usable != value)
                {
                    NotifyPropertyValueChanged("Usable", oldValue:_usable, newValue: value);
                    _usable = value;     
                }
            }
        }


        public bool Watermarked {
            get {
                return _watermarked;
            }
            set {
                if (_watermarked != value)
                {
                    NotifyPropertyValueChanged("Watermarked", oldValue:_watermarked, newValue: value);
                    _watermarked = value;     
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
                    NotifyPropertyValueChanged("Width", oldValue:_width, newValue: value);
                    _width = value;     
                }
            }
        }
    }
}
