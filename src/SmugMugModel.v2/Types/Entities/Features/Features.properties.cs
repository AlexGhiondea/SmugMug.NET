// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FeaturesEntity : SmugMugEntity
    {
        private bool _backprinting;
        private bool _customPackaging;
        private bool _grantAccess;
        private bool _printmarks;
        private bool _rightClickProtection;
        private bool _sales;
        private bool _sharpening;
        private string _uri;
        private string _uriDescription;
        private bool _video;
        private bool _watermarks;


        public bool Backprinting {
            get {
                return _backprinting;
            }
            set {
                if (_backprinting != value)
                {
                    NotifyPropertyValueChanged("Backprinting", oldValue:_backprinting, newValue: value);
                    _backprinting = value;     
                }
            }
        }


        public bool CustomPackaging {
            get {
                return _customPackaging;
            }
            set {
                if (_customPackaging != value)
                {
                    NotifyPropertyValueChanged("CustomPackaging", oldValue:_customPackaging, newValue: value);
                    _customPackaging = value;     
                }
            }
        }


        public bool GrantAccess {
            get {
                return _grantAccess;
            }
            set {
                if (_grantAccess != value)
                {
                    NotifyPropertyValueChanged("GrantAccess", oldValue:_grantAccess, newValue: value);
                    _grantAccess = value;     
                }
            }
        }


        public bool Printmarks {
            get {
                return _printmarks;
            }
            set {
                if (_printmarks != value)
                {
                    NotifyPropertyValueChanged("Printmarks", oldValue:_printmarks, newValue: value);
                    _printmarks = value;     
                }
            }
        }


        public bool RightClickProtection {
            get {
                return _rightClickProtection;
            }
            set {
                if (_rightClickProtection != value)
                {
                    NotifyPropertyValueChanged("RightClickProtection", oldValue:_rightClickProtection, newValue: value);
                    _rightClickProtection = value;     
                }
            }
        }


        public bool Sales {
            get {
                return _sales;
            }
            set {
                if (_sales != value)
                {
                    NotifyPropertyValueChanged("Sales", oldValue:_sales, newValue: value);
                    _sales = value;     
                }
            }
        }


        public bool Sharpening {
            get {
                return _sharpening;
            }
            set {
                if (_sharpening != value)
                {
                    NotifyPropertyValueChanged("Sharpening", oldValue:_sharpening, newValue: value);
                    _sharpening = value;     
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


        public bool Video {
            get {
                return _video;
            }
            set {
                if (_video != value)
                {
                    NotifyPropertyValueChanged("Video", oldValue:_video, newValue: value);
                    _video = value;     
                }
            }
        }


        public bool Watermarks {
            get {
                return _watermarks;
            }
            set {
                if (_watermarks != value)
                {
                    NotifyPropertyValueChanged("Watermarks", oldValue:_watermarks, newValue: value);
                    _watermarks = value;     
                }
            }
        }
    }
}
