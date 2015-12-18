// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizeDetailsEntity : SmugMugEntity
    {
        private string _imageSizeLarge;
        private string _imageSizeMedium;
        private string _imageSizeOriginal;
        private string _imageSizeSmall;
        private string _imageSizeThumb;
        private string _imageSizeTiny;
        private string _imageSizeX2Large;
        private string _imageSizeX3Large;
        private string _imageSizeXLarge;
        private string _imageUrlTemplate;
        private string _uri;
        private string _uriDescription;
        private string _usableSizes;
        private string _videoSize110;
        private string _videoSize1280;
        private string _videoSize1920;
        private string _videoSize200;
        private string _videoSize320;
        private string _videoSize640;
        private string _videoSize960;
        private string _videoSMIL;


        public string ImageSizeLarge {
            get {
                return _imageSizeLarge;
            }
            set {
                if (_imageSizeLarge != value)
                {
                    _imageSizeLarge = value;
                    NotifyPropertyValueChanged("ImageSizeLarge", _imageSizeLarge);
                }
            }
        }


        public string ImageSizeMedium {
            get {
                return _imageSizeMedium;
            }
            set {
                if (_imageSizeMedium != value)
                {
                    _imageSizeMedium = value;
                    NotifyPropertyValueChanged("ImageSizeMedium", _imageSizeMedium);
                }
            }
        }


        public string ImageSizeOriginal {
            get {
                return _imageSizeOriginal;
            }
            set {
                if (_imageSizeOriginal != value)
                {
                    _imageSizeOriginal = value;
                    NotifyPropertyValueChanged("ImageSizeOriginal", _imageSizeOriginal);
                }
            }
        }


        public string ImageSizeSmall {
            get {
                return _imageSizeSmall;
            }
            set {
                if (_imageSizeSmall != value)
                {
                    _imageSizeSmall = value;
                    NotifyPropertyValueChanged("ImageSizeSmall", _imageSizeSmall);
                }
            }
        }


        public string ImageSizeThumb {
            get {
                return _imageSizeThumb;
            }
            set {
                if (_imageSizeThumb != value)
                {
                    _imageSizeThumb = value;
                    NotifyPropertyValueChanged("ImageSizeThumb", _imageSizeThumb);
                }
            }
        }


        public string ImageSizeTiny {
            get {
                return _imageSizeTiny;
            }
            set {
                if (_imageSizeTiny != value)
                {
                    _imageSizeTiny = value;
                    NotifyPropertyValueChanged("ImageSizeTiny", _imageSizeTiny);
                }
            }
        }


        public string ImageSizeX2Large {
            get {
                return _imageSizeX2Large;
            }
            set {
                if (_imageSizeX2Large != value)
                {
                    _imageSizeX2Large = value;
                    NotifyPropertyValueChanged("ImageSizeX2Large", _imageSizeX2Large);
                }
            }
        }


        public string ImageSizeX3Large {
            get {
                return _imageSizeX3Large;
            }
            set {
                if (_imageSizeX3Large != value)
                {
                    _imageSizeX3Large = value;
                    NotifyPropertyValueChanged("ImageSizeX3Large", _imageSizeX3Large);
                }
            }
        }


        public string ImageSizeXLarge {
            get {
                return _imageSizeXLarge;
            }
            set {
                if (_imageSizeXLarge != value)
                {
                    _imageSizeXLarge = value;
                    NotifyPropertyValueChanged("ImageSizeXLarge", _imageSizeXLarge);
                }
            }
        }


        public string ImageUrlTemplate {
            get {
                return _imageUrlTemplate;
            }
            set {
                if (_imageUrlTemplate != value)
                {
                    _imageUrlTemplate = value;
                    NotifyPropertyValueChanged("ImageUrlTemplate", _imageUrlTemplate);
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


        public string UsableSizes {
            get {
                return _usableSizes;
            }
            set {
                if (_usableSizes != value)
                {
                    _usableSizes = value;
                    NotifyPropertyValueChanged("UsableSizes", _usableSizes);
                }
            }
        }


        public string VideoSize110 {
            get {
                return _videoSize110;
            }
            set {
                if (_videoSize110 != value)
                {
                    _videoSize110 = value;
                    NotifyPropertyValueChanged("VideoSize110", _videoSize110);
                }
            }
        }


        public string VideoSize1280 {
            get {
                return _videoSize1280;
            }
            set {
                if (_videoSize1280 != value)
                {
                    _videoSize1280 = value;
                    NotifyPropertyValueChanged("VideoSize1280", _videoSize1280);
                }
            }
        }


        public string VideoSize1920 {
            get {
                return _videoSize1920;
            }
            set {
                if (_videoSize1920 != value)
                {
                    _videoSize1920 = value;
                    NotifyPropertyValueChanged("VideoSize1920", _videoSize1920);
                }
            }
        }


        public string VideoSize200 {
            get {
                return _videoSize200;
            }
            set {
                if (_videoSize200 != value)
                {
                    _videoSize200 = value;
                    NotifyPropertyValueChanged("VideoSize200", _videoSize200);
                }
            }
        }


        public string VideoSize320 {
            get {
                return _videoSize320;
            }
            set {
                if (_videoSize320 != value)
                {
                    _videoSize320 = value;
                    NotifyPropertyValueChanged("VideoSize320", _videoSize320);
                }
            }
        }


        public string VideoSize640 {
            get {
                return _videoSize640;
            }
            set {
                if (_videoSize640 != value)
                {
                    _videoSize640 = value;
                    NotifyPropertyValueChanged("VideoSize640", _videoSize640);
                }
            }
        }


        public string VideoSize960 {
            get {
                return _videoSize960;
            }
            set {
                if (_videoSize960 != value)
                {
                    _videoSize960 = value;
                    NotifyPropertyValueChanged("VideoSize960", _videoSize960);
                }
            }
        }


        public string VideoSMIL {
            get {
                return _videoSMIL;
            }
            set {
                if (_videoSMIL != value)
                {
                    _videoSMIL = value;
                    NotifyPropertyValueChanged("VideoSMIL", _videoSMIL);
                }
            }
        }
    }
}
