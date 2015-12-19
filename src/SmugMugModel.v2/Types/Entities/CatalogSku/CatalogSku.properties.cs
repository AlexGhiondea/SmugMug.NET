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
                    _borderHeight = value;
                    NotifyPropertyValueChanged("BorderHeight", _borderHeight);
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
                    _borderWidth = value;
                    NotifyPropertyValueChanged("BorderWidth", _borderWidth);
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
                    _cartItemLimit = value;
                    NotifyPropertyValueChanged("CartItemLimit", _cartItemLimit);
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


        public long MaxQuantity {
            get {
                return _maxQuantity;
            }
            set {
                if (_maxQuantity != value)
                {
                    _maxQuantity = value;
                    NotifyPropertyValueChanged("MaxQuantity", _maxQuantity);
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
                    _minResHeight = value;
                    NotifyPropertyValueChanged("MinResHeight", _minResHeight);
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
                    _minResWidth = value;
                    NotifyPropertyValueChanged("MinResWidth", _minResWidth);
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
                    _priceable = value;
                    NotifyPropertyValueChanged("Priceable", _priceable);
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
                    _skuID = value;
                    NotifyPropertyValueChanged("SkuID", _skuID);
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
    }
}
