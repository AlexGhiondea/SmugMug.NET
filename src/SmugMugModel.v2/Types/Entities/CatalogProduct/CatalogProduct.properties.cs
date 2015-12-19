// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogProductEntity : SmugMugEntity
    {
        private float _colorCorrectionPrice;
        private string _description;
        private bool _enabled;
        private long _group;
        private float _height;
        private string _name;
        private string _optionType;
        private long _sortIndex;
        private string _uri;
        private string _uriDescription;
        private float _width;


        public float ColorCorrectionPrice {
            get {
                return _colorCorrectionPrice;
            }
            set {
                if (_colorCorrectionPrice != value)
                {
                    _colorCorrectionPrice = value;
                    NotifyPropertyValueChanged("ColorCorrectionPrice", _colorCorrectionPrice);
                }
            }
        }


        public string Description {
            get {
                return _description;
            }
            set {
                if (_description != value)
                {
                    _description = value;
                    NotifyPropertyValueChanged("Description", _description);
                }
            }
        }


        public bool Enabled {
            get {
                return _enabled;
            }
            set {
                if (_enabled != value)
                {
                    _enabled = value;
                    NotifyPropertyValueChanged("Enabled", _enabled);
                }
            }
        }


        public long Group {
            get {
                return _group;
            }
            set {
                if (_group != value)
                {
                    _group = value;
                    NotifyPropertyValueChanged("Group", _group);
                }
            }
        }


        public float Height {
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


        public string OptionType {
            get {
                return _optionType;
            }
            set {
                if (_optionType != value)
                {
                    _optionType = value;
                    NotifyPropertyValueChanged("OptionType", _optionType);
                }
            }
        }


        public long SortIndex {
            get {
                return _sortIndex;
            }
            set {
                if (_sortIndex != value)
                {
                    _sortIndex = value;
                    NotifyPropertyValueChanged("SortIndex", _sortIndex);
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


        public float Width {
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
