// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuEntity : SmugMugEntity
    {
        private float _borderHeight;
        private float _borderWidth;
        private long _cartItemLimit;
        private bool _enabled;
        private long _maxQuantity;
        private long _minResHeight;
        private long _minResWidth;
        private bool _priceable;
        private long _skuID;
        private string _uri;
        private string _uriDescription;


        public float BorderHeight {
            get {
                return _borderHeight;
            }
            set {
                if (_borderHeight != value)
                {
                    NotifyPropertyValueChanged("BorderHeight", oldValue:_borderHeight, newValue: value);
                    _borderHeight = value;     
                }
            }
        }


        public float BorderWidth {
            get {
                return _borderWidth;
            }
            set {
                if (_borderWidth != value)
                {
                    NotifyPropertyValueChanged("BorderWidth", oldValue:_borderWidth, newValue: value);
                    _borderWidth = value;     
                }
            }
        }


        public long CartItemLimit {
            get {
                return _cartItemLimit;
            }
            set {
                if (_cartItemLimit != value)
                {
                    NotifyPropertyValueChanged("CartItemLimit", oldValue:_cartItemLimit, newValue: value);
                    _cartItemLimit = value;     
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


        public long MaxQuantity {
            get {
                return _maxQuantity;
            }
            set {
                if (_maxQuantity != value)
                {
                    NotifyPropertyValueChanged("MaxQuantity", oldValue:_maxQuantity, newValue: value);
                    _maxQuantity = value;     
                }
            }
        }


        public long MinResHeight {
            get {
                return _minResHeight;
            }
            set {
                if (_minResHeight != value)
                {
                    NotifyPropertyValueChanged("MinResHeight", oldValue:_minResHeight, newValue: value);
                    _minResHeight = value;     
                }
            }
        }


        public long MinResWidth {
            get {
                return _minResWidth;
            }
            set {
                if (_minResWidth != value)
                {
                    NotifyPropertyValueChanged("MinResWidth", oldValue:_minResWidth, newValue: value);
                    _minResWidth = value;     
                }
            }
        }


        public bool Priceable {
            get {
                return _priceable;
            }
            set {
                if (_priceable != value)
                {
                    NotifyPropertyValueChanged("Priceable", oldValue:_priceable, newValue: value);
                    _priceable = value;     
                }
            }
        }


        public long SkuID {
            get {
                return _skuID;
            }
            set {
                if (_skuID != value)
                {
                    NotifyPropertyValueChanged("SkuID", oldValue:_skuID, newValue: value);
                    _skuID = value;     
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
    }
}
