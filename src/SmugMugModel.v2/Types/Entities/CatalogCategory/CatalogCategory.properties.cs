// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CatalogCategoryEntity : SmugMugEntity
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
                    NotifyPropertyValueChanged("Description", oldValue:_description, newValue: value);
                    _description = value;     
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
    }
}
