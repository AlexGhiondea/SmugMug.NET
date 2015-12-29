// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogSkuPriceEntity : SmugMugEntity
    {
        private string _currency;
        private float _price;
        private string _responseLevel;

        public string Currency {
            get {
                return _currency;
            }
            set {
                if (_currency != value)
                {
                    NotifyPropertyValueChanged("Currency", oldValue:_currency, newValue: value);
                    _currency = value;     
                }
            }
        }


        public float Price {
            get {
                return _price;
            }
            set {
                if (_price != value)
                {
                    NotifyPropertyValueChanged("Price", oldValue:_price, newValue: value);
                    _price = value;     
                }
            }
        }


        public string ResponseLevel {
            get {
                return _responseLevel;
            }
            set {
                if (_responseLevel != value)
                {
                    NotifyPropertyValueChanged("ResponseLevel", oldValue:_responseLevel, newValue: value);
                    _responseLevel = value;     
                }
            }
        }
    }
}
