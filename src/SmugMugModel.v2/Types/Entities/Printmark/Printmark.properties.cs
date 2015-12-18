// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class PrintmarkEntity : SmugMugEntity
    {
        private int _dissolve;
        private int _gap;
        private int _imageID;
        private string _imageKey;
        private string _imageUri;
        private string _location;
        private string _name;
        private int _printmarkID;
        private int _scale;


        public int Dissolve {
            get {
                return _dissolve;
            }
            set {
                if (_dissolve != value)
                {
                    _dissolve = value;
                    NotifyPropertyValueChanged("Dissolve", _dissolve);
                }
            }
        }


        public int Gap {
            get {
                return _gap;
            }
            set {
                if (_gap != value)
                {
                    _gap = value;
                    NotifyPropertyValueChanged("Gap", _gap);
                }
            }
        }


        public int ImageID {
            get {
                return _imageID;
            }
            set {
                if (_imageID != value)
                {
                    _imageID = value;
                    NotifyPropertyValueChanged("ImageID", _imageID);
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
                    _imageKey = value;
                    NotifyPropertyValueChanged("ImageKey", _imageKey);
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
                    _imageUri = value;
                    NotifyPropertyValueChanged("ImageUri", _imageUri);
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
                    _location = value;
                    NotifyPropertyValueChanged("Location", _location);
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
                    _name = value;
                    NotifyPropertyValueChanged("Name", _name);
                }
            }
        }


        public int PrintmarkID {
            get {
                return _printmarkID;
            }
            set {
                if (_printmarkID != value)
                {
                    _printmarkID = value;
                    NotifyPropertyValueChanged("PrintmarkID", _printmarkID);
                }
            }
        }


        public int Scale {
            get {
                return _scale;
            }
            set {
                if (_scale != value)
                {
                    _scale = value;
                    NotifyPropertyValueChanged("Scale", _scale);
                }
            }
        }
    }
}
