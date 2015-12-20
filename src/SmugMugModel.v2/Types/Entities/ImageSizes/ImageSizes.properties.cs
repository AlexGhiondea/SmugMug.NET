// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {
        private string __110VideoUrl;
        private string __1280VideoUrl;
        private string __1920VideoUrl;
        private string __200VideoUrl;
        private string __320VideoUrl;
        private string __640VideoUrl;
        private string __960VideoUrl;
        private string _largeImageUrl;
        private string _largestImageUrl;
        private string _largestVideoUrl;
        private string _mediumImageUrl;
        private string _originalImageUrl;
        private string _smallImageUrl;
        private string _sMILVideoUrl;
        private string _thumbImageUrl;
        private string _tinyImageUrl;
        private string _uri;
        private string _uriDescription;
        private string _x2LargeImageUrl;
        private string _x3LargeImageUrl;
        private string _xLargeImageUrl;


        public string _110VideoUrl {
            get {
                return __110VideoUrl;
            }
            set {
                if (__110VideoUrl != value)
                {
                    __110VideoUrl = value;
                    NotifyPropertyValueChanged("_110VideoUrl", __110VideoUrl);
                }
            }
        }


        public string _1280VideoUrl {
            get {
                return __1280VideoUrl;
            }
            set {
                if (__1280VideoUrl != value)
                {
                    __1280VideoUrl = value;
                    NotifyPropertyValueChanged("_1280VideoUrl", __1280VideoUrl);
                }
            }
        }


        public string _1920VideoUrl {
            get {
                return __1920VideoUrl;
            }
            set {
                if (__1920VideoUrl != value)
                {
                    __1920VideoUrl = value;
                    NotifyPropertyValueChanged("_1920VideoUrl", __1920VideoUrl);
                }
            }
        }


        public string _200VideoUrl {
            get {
                return __200VideoUrl;
            }
            set {
                if (__200VideoUrl != value)
                {
                    __200VideoUrl = value;
                    NotifyPropertyValueChanged("_200VideoUrl", __200VideoUrl);
                }
            }
        }


        public string _320VideoUrl {
            get {
                return __320VideoUrl;
            }
            set {
                if (__320VideoUrl != value)
                {
                    __320VideoUrl = value;
                    NotifyPropertyValueChanged("_320VideoUrl", __320VideoUrl);
                }
            }
        }


        public string _640VideoUrl {
            get {
                return __640VideoUrl;
            }
            set {
                if (__640VideoUrl != value)
                {
                    __640VideoUrl = value;
                    NotifyPropertyValueChanged("_640VideoUrl", __640VideoUrl);
                }
            }
        }


        public string _960VideoUrl {
            get {
                return __960VideoUrl;
            }
            set {
                if (__960VideoUrl != value)
                {
                    __960VideoUrl = value;
                    NotifyPropertyValueChanged("_960VideoUrl", __960VideoUrl);
                }
            }
        }


        public string LargeImageUrl {
            get {
                return _largeImageUrl;
            }
            set {
                if (_largeImageUrl != value)
                {
                    _largeImageUrl = value;
                    NotifyPropertyValueChanged("LargeImageUrl", _largeImageUrl);
                }
            }
        }


        public string LargestImageUrl {
            get {
                return _largestImageUrl;
            }
            set {
                if (_largestImageUrl != value)
                {
                    _largestImageUrl = value;
                    NotifyPropertyValueChanged("LargestImageUrl", _largestImageUrl);
                }
            }
        }


        public string LargestVideoUrl {
            get {
                return _largestVideoUrl;
            }
            set {
                if (_largestVideoUrl != value)
                {
                    _largestVideoUrl = value;
                    NotifyPropertyValueChanged("LargestVideoUrl", _largestVideoUrl);
                }
            }
        }


        public string MediumImageUrl {
            get {
                return _mediumImageUrl;
            }
            set {
                if (_mediumImageUrl != value)
                {
                    _mediumImageUrl = value;
                    NotifyPropertyValueChanged("MediumImageUrl", _mediumImageUrl);
                }
            }
        }


        public string OriginalImageUrl {
            get {
                return _originalImageUrl;
            }
            set {
                if (_originalImageUrl != value)
                {
                    _originalImageUrl = value;
                    NotifyPropertyValueChanged("OriginalImageUrl", _originalImageUrl);
                }
            }
        }


        public string SmallImageUrl {
            get {
                return _smallImageUrl;
            }
            set {
                if (_smallImageUrl != value)
                {
                    _smallImageUrl = value;
                    NotifyPropertyValueChanged("SmallImageUrl", _smallImageUrl);
                }
            }
        }


        public string SMILVideoUrl {
            get {
                return _sMILVideoUrl;
            }
            set {
                if (_sMILVideoUrl != value)
                {
                    _sMILVideoUrl = value;
                    NotifyPropertyValueChanged("SMILVideoUrl", _sMILVideoUrl);
                }
            }
        }


        public string ThumbImageUrl {
            get {
                return _thumbImageUrl;
            }
            set {
                if (_thumbImageUrl != value)
                {
                    _thumbImageUrl = value;
                    NotifyPropertyValueChanged("ThumbImageUrl", _thumbImageUrl);
                }
            }
        }


        public string TinyImageUrl {
            get {
                return _tinyImageUrl;
            }
            set {
                if (_tinyImageUrl != value)
                {
                    _tinyImageUrl = value;
                    NotifyPropertyValueChanged("TinyImageUrl", _tinyImageUrl);
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


        public string X2LargeImageUrl {
            get {
                return _x2LargeImageUrl;
            }
            set {
                if (_x2LargeImageUrl != value)
                {
                    _x2LargeImageUrl = value;
                    NotifyPropertyValueChanged("X2LargeImageUrl", _x2LargeImageUrl);
                }
            }
        }


        public string X3LargeImageUrl {
            get {
                return _x3LargeImageUrl;
            }
            set {
                if (_x3LargeImageUrl != value)
                {
                    _x3LargeImageUrl = value;
                    NotifyPropertyValueChanged("X3LargeImageUrl", _x3LargeImageUrl);
                }
            }
        }


        public string XLargeImageUrl {
            get {
                return _xLargeImageUrl;
            }
            set {
                if (_xLargeImageUrl != value)
                {
                    _xLargeImageUrl = value;
                    NotifyPropertyValueChanged("XLargeImageUrl", _xLargeImageUrl);
                }
            }
        }
    }
}
