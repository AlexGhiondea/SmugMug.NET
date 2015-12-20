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
        private string _uri;
        private string _uriDescription;


        public string Currency {
            get {
                return _currency;
            }
            set {
                if (_currency != value)
                {
                    _currency = value;
                    NotifyPropertyValueChanged("Currency", _currency);
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
                    _price = value;
                    NotifyPropertyValueChanged("Price", _price);
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
                    _responseLevel = value;
                    NotifyPropertyValueChanged("ResponseLevel", _responseLevel);
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
