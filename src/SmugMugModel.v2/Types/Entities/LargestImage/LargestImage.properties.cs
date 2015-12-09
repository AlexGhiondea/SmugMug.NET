// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {
        private string _ext;
        private int _height;
        private int _size;
        private string _uri;
        private string _uriDescription;
        private string _url;
        private bool _usable;
        private bool _watermarked;
        private int _width;


        public string Ext {
            get {
                return _ext;
            }
            set {
                if (_ext != value)
                {
                    _ext = value;
                    NotifyPropertyValueChanged("Ext", _ext);
                }
            }
        }


        public int Height {
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


        public int Size {
            get {
                return _size;
            }
            set {
                if (_size != value)
                {
                    _size = value;
                    NotifyPropertyValueChanged("Size", _size);
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


        public string Url {
            get {
                return _url;
            }
            set {
                if (_url != value)
                {
                    _url = value;
                    NotifyPropertyValueChanged("Url", _url);
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
                    _usable = value;
                    NotifyPropertyValueChanged("Usable", _usable);
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
                    _watermarked = value;
                    NotifyPropertyValueChanged("Watermarked", _watermarked);
                }
            }
        }


        public int Width {
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
