// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeCustomEntity : SmugMugEntity
    {
        private string _ext;
        private long _requestedHeight;
        private long _requestedWidth;
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
                    NotifyPropertyValueChanged("Ext", oldValue:_ext, newValue: value);
                    _ext = value;     
                }
            }
        }


        public long RequestedHeight {
            get {
                return _requestedHeight;
            }
            set {
                if (_requestedHeight != value)
                {
                    NotifyPropertyValueChanged("RequestedHeight", oldValue:_requestedHeight, newValue: value);
                    _requestedHeight = value;     
                }
            }
        }


        public long RequestedWidth {
            get {
                return _requestedWidth;
            }
            set {
                if (_requestedWidth != value)
                {
                    NotifyPropertyValueChanged("RequestedWidth", oldValue:_requestedWidth, newValue: value);
                    _requestedWidth = value;     
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
    }
}
