// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedFolderEntity : SmugMugEntity
    {
        private DateTime _dateAdded;
        private DateTime _dateDeleted;
        private DateTime _dateModified;
        private string _name;
        private string _uri;
        private string _uriDescription;
        private string _urlPath;


        public DateTime DateAdded {
            get {
                return _dateAdded;
            }
            set {
                if (_dateAdded != value)
                {
                    NotifyPropertyValueChanged("DateAdded", oldValue:_dateAdded, newValue: value);
                    _dateAdded = value;     
                }
            }
        }


        public DateTime DateDeleted {
            get {
                return _dateDeleted;
            }
            set {
                if (_dateDeleted != value)
                {
                    NotifyPropertyValueChanged("DateDeleted", oldValue:_dateDeleted, newValue: value);
                    _dateDeleted = value;     
                }
            }
        }


        public DateTime DateModified {
            get {
                return _dateModified;
            }
            set {
                if (_dateModified != value)
                {
                    NotifyPropertyValueChanged("DateModified", oldValue:_dateModified, newValue: value);
                    _dateModified = value;     
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


        public string UrlPath {
            get {
                return _urlPath;
            }
            set {
                if (_urlPath != value)
                {
                    NotifyPropertyValueChanged("UrlPath", oldValue:_urlPath, newValue: value);
                    _urlPath = value;     
                }
            }
        }
    }
}
