// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DownloadEntity : SmugMugEntity
    {
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private string _fileName;
        private long _part;
        private ImageStatusEnum _status;
        private string _uri;
        private string _uriDescription;


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


        public string FileName {
            get {
                return _fileName;
            }
            set {
                if (_fileName != value)
                {
                    _fileName = value;
                    NotifyPropertyValueChanged("FileName", _fileName);
                }
            }
        }


        public long Part {
            get {
                return _part;
            }
            set {
                if (_part != value)
                {
                    _part = value;
                    NotifyPropertyValueChanged("Part", _part);
                }
            }
        }


        public ImageStatusEnum Status {
            get {
                return _status;
            }
            set {
                if (_status != value)
                {
                    _status = value;
                    NotifyPropertyValueChanged("Status", _status);
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
