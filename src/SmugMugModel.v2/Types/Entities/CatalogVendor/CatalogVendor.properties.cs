// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogVendorEntity : SmugMugEntity
    {
        private string _description;
        private string _name;
        private long _sortIndex;
        private string _uri;
        private string _uriDescription;


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
    }
}
