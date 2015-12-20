// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedAlbumEntity : SmugMugEntity
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
                    _dateAdded = value;
                    NotifyPropertyValueChanged("DateAdded", _dateAdded);
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
                    _dateDeleted = value;
                    NotifyPropertyValueChanged("DateDeleted", _dateDeleted);
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
                    _dateModified = value;
                    NotifyPropertyValueChanged("DateModified", _dateModified);
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


        public string UrlPath {
            get {
                return _urlPath;
            }
            set {
                if (_urlPath != value)
                {
                    _urlPath = value;
                    NotifyPropertyValueChanged("UrlPath", _urlPath);
                }
            }
        }
    }
}
