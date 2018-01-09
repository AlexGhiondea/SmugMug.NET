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
                    NotifyPropertyValueChanged("ImageSizeLarge", oldValue:_imageSizeLarge, newValue: value);
                    _imageSizeLarge = value;     
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
                    NotifyPropertyValueChanged("ImageSizeMedium", oldValue:_imageSizeMedium, newValue: value);
                    _imageSizeMedium = value;     
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
                    NotifyPropertyValueChanged("ImageSizeOriginal", oldValue:_imageSizeOriginal, newValue: value);
                    _imageSizeOriginal = value;     
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
                    NotifyPropertyValueChanged("ImageSizeSmall", oldValue:_imageSizeSmall, newValue: value);
                    _imageSizeSmall = value;     
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
                    NotifyPropertyValueChanged("ImageSizeThumb", oldValue:_imageSizeThumb, newValue: value);
                    _imageSizeThumb = value;     
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
                    NotifyPropertyValueChanged("ImageSizeTiny", oldValue:_imageSizeTiny, newValue: value);
                    _imageSizeTiny = value;     
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
                    NotifyPropertyValueChanged("ImageSizeX2Large", oldValue:_imageSizeX2Large, newValue: value);
                    _imageSizeX2Large = value;     
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
                    NotifyPropertyValueChanged("ImageSizeX3Large", oldValue:_imageSizeX3Large, newValue: value);
                    _imageSizeX3Large = value;     
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
                    NotifyPropertyValueChanged("ImageSizeXLarge", oldValue:_imageSizeXLarge, newValue: value);
                    _imageSizeXLarge = value;     
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
                    NotifyPropertyValueChanged("ImageUrlTemplate", oldValue:_imageUrlTemplate, newValue: value);
                    _imageUrlTemplate = value;     
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
                    NotifyPropertyValueChanged("UsableSizes", oldValue:_usableSizes, newValue: value);
                    _usableSizes = value;     
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
                    NotifyPropertyValueChanged("VideoSize110", oldValue:_videoSize110, newValue: value);
                    _videoSize110 = value;     
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
                    NotifyPropertyValueChanged("VideoSize1280", oldValue:_videoSize1280, newValue: value);
                    _videoSize1280 = value;     
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
                    NotifyPropertyValueChanged("VideoSize1920", oldValue:_videoSize1920, newValue: value);
                    _videoSize1920 = value;     
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
                    NotifyPropertyValueChanged("VideoSize200", oldValue:_videoSize200, newValue: value);
                    _videoSize200 = value;     
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
                    NotifyPropertyValueChanged("VideoSize320", oldValue:_videoSize320, newValue: value);
                    _videoSize320 = value;     
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
                    NotifyPropertyValueChanged("VideoSize640", oldValue:_videoSize640, newValue: value);
                    _videoSize640 = value;     
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
                    NotifyPropertyValueChanged("VideoSize960", oldValue:_videoSize960, newValue: value);
                    _videoSize960 = value;     
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
                    NotifyPropertyValueChanged("VideoSMIL", oldValue:_videoSMIL, newValue: value);
                    _videoSMIL = value;     
                }
            }
        }
    }
}
