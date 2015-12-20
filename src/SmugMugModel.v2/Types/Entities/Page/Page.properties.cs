// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class PageEntity : SmugMugEntity
    {
        private bool _autoRename;
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private string _highlightImageUri;
        private string _name;
        private string _password;
        private string _passwordHint;
        private PrivacyEnum _privacy;
        private SecurityTypeEnum _securityType;
        private string _urlName;
        private string _urlPath;


        public bool AutoRename {
            get {
                return _autoRename;
            }
            set {
                if (_autoRename != value)
                {
                    _autoRename = value;
                    NotifyPropertyValueChanged("AutoRename", _autoRename);
                }
            }
        }


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


        public string HighlightImageUri {
            get {
                return _highlightImageUri;
            }
            set {
                if (_highlightImageUri != value)
                {
                    _highlightImageUri = value;
                    NotifyPropertyValueChanged("HighlightImageUri", _highlightImageUri);
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


        public string Password {
            get {
                return _password;
            }
            set {
                if (_password != value)
                {
                    _password = value;
                    NotifyPropertyValueChanged("Password", _password);
                }
            }
        }


        public string PasswordHint {
            get {
                return _passwordHint;
            }
            set {
                if (_passwordHint != value)
                {
                    _passwordHint = value;
                    NotifyPropertyValueChanged("PasswordHint", _passwordHint);
                }
            }
        }


        public PrivacyEnum Privacy {
            get {
                return _privacy;
            }
            set {
                if (_privacy != value)
                {
                    _privacy = value;
                    NotifyPropertyValueChanged("Privacy", _privacy);
                }
            }
        }


        public SecurityTypeEnum SecurityType {
            get {
                return _securityType;
            }
            set {
                if (_securityType != value)
                {
                    _securityType = value;
                    NotifyPropertyValueChanged("SecurityType", _securityType);
                }
            }
        }


        public string UrlName {
            get {
                return _urlName;
            }
            set {
                if (_urlName != value)
                {
                    _urlName = value;
                    NotifyPropertyValueChanged("UrlName", _urlName);
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
