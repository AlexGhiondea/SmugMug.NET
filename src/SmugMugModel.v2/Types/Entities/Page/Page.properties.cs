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
                    NotifyPropertyValueChanged("AutoRename", oldValue:_autoRename, newValue: value);
                    _autoRename = value;     
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
                    NotifyPropertyValueChanged("DateAdded", oldValue:_dateAdded, newValue: value);
                    _dateAdded = value;     
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


        public string HighlightImageUri {
            get {
                return _highlightImageUri;
            }
            set {
                if (_highlightImageUri != value)
                {
                    NotifyPropertyValueChanged("HighlightImageUri", oldValue:_highlightImageUri, newValue: value);
                    _highlightImageUri = value;     
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


        public string Password {
            get {
                return _password;
            }
            set {
                if (_password != value)
                {
                    NotifyPropertyValueChanged("Password", oldValue:_password, newValue: value);
                    _password = value;     
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
                    NotifyPropertyValueChanged("PasswordHint", oldValue:_passwordHint, newValue: value);
                    _passwordHint = value;     
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
                    NotifyPropertyValueChanged("Privacy", oldValue:_privacy, newValue: value);
                    _privacy = value;     
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
                    NotifyPropertyValueChanged("SecurityType", oldValue:_securityType, newValue: value);
                    _securityType = value;     
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
                    NotifyPropertyValueChanged("UrlName", oldValue:_urlName, newValue: value);
                    _urlName = value;     
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
