// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderEntity : SmugMugEntity
    {
        private bool _autoRename;
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private string _description;
        private string _highlightImageUri;
        private bool _isEmpty;
        private string _keywords;
        private string _name;
        private string _nodeID;
        private string _password;
        private string _passwordHint;
        private PrivacyEnum _privacy;
        private string _responseLevel;
        private SecurityTypeEnum _securityType;
        private SmugSearchableEnum _smugSearchable;
        private SortDirectionEnum _sortDirection;
        private SortMethodEnum _sortMethod;
        private string _uri;
        private string _uriDescription;
        private string _urlName;
        private string _urlPath;
        private string _webUri;
        private WorldSearchableEnum _worldSearchable;


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


        public bool IsEmpty {
            get {
                return _isEmpty;
            }
            set {
                if (_isEmpty != value)
                {
                    _isEmpty = value;
                    NotifyPropertyValueChanged("IsEmpty", _isEmpty);
                }
            }
        }


        public string Keywords {
            get {
                return _keywords;
            }
            set {
                if (_keywords != value)
                {
                    _keywords = value;
                    NotifyPropertyValueChanged("Keywords", _keywords);
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


        public string NodeID {
            get {
                return _nodeID;
            }
            set {
                if (_nodeID != value)
                {
                    _nodeID = value;
                    NotifyPropertyValueChanged("NodeID", _nodeID);
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


        public SmugSearchableEnum SmugSearchable {
            get {
                return _smugSearchable;
            }
            set {
                if (_smugSearchable != value)
                {
                    _smugSearchable = value;
                    NotifyPropertyValueChanged("SmugSearchable", _smugSearchable);
                }
            }
        }


        public SortDirectionEnum SortDirection {
            get {
                return _sortDirection;
            }
            set {
                if (_sortDirection != value)
                {
                    _sortDirection = value;
                    NotifyPropertyValueChanged("SortDirection", _sortDirection);
                }
            }
        }


        public SortMethodEnum SortMethod {
            get {
                return _sortMethod;
            }
            set {
                if (_sortMethod != value)
                {
                    _sortMethod = value;
                    NotifyPropertyValueChanged("SortMethod", _sortMethod);
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


        public string WebUri {
            get {
                return _webUri;
            }
            set {
                if (_webUri != value)
                {
                    _webUri = value;
                    NotifyPropertyValueChanged("WebUri", _webUri);
                }
            }
        }


        public WorldSearchableEnum WorldSearchable {
            get {
                return _worldSearchable;
            }
            set {
                if (_worldSearchable != value)
                {
                    _worldSearchable = value;
                    NotifyPropertyValueChanged("WorldSearchable", _worldSearchable);
                }
            }
        }
    }
}
