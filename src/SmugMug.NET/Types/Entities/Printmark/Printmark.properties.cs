// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class PrintmarkEntity : SmugMugEntity
    {
        private long _dissolve;
        private long _gap;
        private long _imageID;
        private string _imageKey;
        private string _imageUri;
        private string _location;
        private string _name;
        private long _printmarkID;
        private long _scale;


        public long Dissolve {
            get {
                return _dissolve;
            }
            set {
                if (_dissolve != value)
                {
                    NotifyPropertyValueChanged("Dissolve", oldValue:_dissolve, newValue: value);
                    _dissolve = value;     
                }
            }
        }


        public long Gap {
            get {
                return _gap;
            }
            set {
                if (_gap != value)
                {
                    NotifyPropertyValueChanged("Gap", oldValue:_gap, newValue: value);
                    _gap = value;     
                }
            }
        }


        public long ImageID {
            get {
                return _imageID;
            }
            set {
                if (_imageID != value)
                {
                    NotifyPropertyValueChanged("ImageID", oldValue:_imageID, newValue: value);
                    _imageID = value;     
                }
            }
        }


        public string ImageKey {
            get {
                return _imageKey;
            }
            set {
                if (_imageKey != value)
                {
                    NotifyPropertyValueChanged("ImageKey", oldValue:_imageKey, newValue: value);
                    _imageKey = value;     
                }
            }
        }


        public string ImageUri {
            get {
                return _imageUri;
            }
            set {
                if (_imageUri != value)
                {
                    NotifyPropertyValueChanged("ImageUri", oldValue:_imageUri, newValue: value);
                    _imageUri = value;     
                }
            }
        }


        public string Location {
            get {
                return _location;
            }
            set {
                if (_location != value)
                {
                    NotifyPropertyValueChanged("Location", oldValue:_location, newValue: value);
                    _location = value;     
                }
            }
        }


        public string Name {
            get {
                return _name;
            }
            set {
                if (_name != value)
                {
                    NotifyPropertyValueChanged("Name", oldValue:_name, newValue: value);
                    _name = value;     
                }
            }
        }


        public long PrintmarkID {
            get {
                return _printmarkID;
            }
            set {
                if (_printmarkID != value)
                {
                    NotifyPropertyValueChanged("PrintmarkID", oldValue:_printmarkID, newValue: value);
                    _printmarkID = value;     
                }
            }
        }


        public long Scale {
            get {
                return _scale;
            }
            set {
                if (_scale != value)
                {
                    NotifyPropertyValueChanged("Scale", oldValue:_scale, newValue: value);
                    _scale = value;     
                }
            }
        }
    }
}
