// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeCustomEntity : SmugMugEntity
    {
        private string _ext;
        private int _requestedHeight;
        private int _requestedWidth;
        private string _url;
        private bool _usable;
        private bool _watermarked;


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


        public int RequestedHeight {
            get {
                return _requestedHeight;
            }
            set {
                if (_requestedHeight != value)
                {
                    _requestedHeight = value;
                    NotifyPropertyValueChanged("RequestedHeight", _requestedHeight);
                }
            }
        }


        public int RequestedWidth {
            get {
                return _requestedWidth;
            }
            set {
                if (_requestedWidth != value)
                {
                    _requestedWidth = value;
                    NotifyPropertyValueChanged("RequestedWidth", _requestedWidth);
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



    }
}
