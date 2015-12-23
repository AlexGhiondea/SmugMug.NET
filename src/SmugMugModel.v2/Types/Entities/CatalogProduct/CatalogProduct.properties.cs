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
                    NotifyPropertyValueChanged("ColorCorrectionPrice", oldValue:_colorCorrectionPrice, newValue: value);
                    _colorCorrectionPrice = value;     
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
                    NotifyPropertyValueChanged("Description", oldValue:_description, newValue: value);
                    _description = value;     
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
                    NotifyPropertyValueChanged("Enabled", oldValue:_enabled, newValue: value);
                    _enabled = value;     
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
                    NotifyPropertyValueChanged("Group", oldValue:_group, newValue: value);
                    _group = value;     
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
                    NotifyPropertyValueChanged("Height", oldValue:_height, newValue: value);
                    _height = value;     
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


        public string OptionType {
            get {
                return _optionType;
            }
            set {
                if (_optionType != value)
                {
                    NotifyPropertyValueChanged("OptionType", oldValue:_optionType, newValue: value);
                    _optionType = value;     
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
                    NotifyPropertyValueChanged("SortIndex", oldValue:_sortIndex, newValue: value);
                    _sortIndex = value;     
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


        public float Width {
            get {
                return _width;
            }
            set {
                if (_width != value)
                {
                    NotifyPropertyValueChanged("Width", oldValue:_width, newValue: value);
                    _width = value;     
                }
            }
        }
    }
}
