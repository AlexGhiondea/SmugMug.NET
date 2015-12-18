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
                    _backprinting = value;
                    NotifyPropertyValueChanged("Backprinting", _backprinting);
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
                    _customPackaging = value;
                    NotifyPropertyValueChanged("CustomPackaging", _customPackaging);
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
                    _grantAccess = value;
                    NotifyPropertyValueChanged("GrantAccess", _grantAccess);
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
                    _printmarks = value;
                    NotifyPropertyValueChanged("Printmarks", _printmarks);
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
                    _rightClickProtection = value;
                    NotifyPropertyValueChanged("RightClickProtection", _rightClickProtection);
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
                    _sales = value;
                    NotifyPropertyValueChanged("Sales", _sales);
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
                    _sharpening = value;
                    NotifyPropertyValueChanged("Sharpening", _sharpening);
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


        public bool Video {
            get {
                return _video;
            }
            set {
                if (_video != value)
                {
                    _video = value;
                    NotifyPropertyValueChanged("Video", _video);
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
                    _watermarks = value;
                    NotifyPropertyValueChanged("Watermarks", _watermarks);
                }
            }
        }
    }
}
