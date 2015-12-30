// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {
        private bool _autoRename;
        private DateTime _dateAdded;
        private DateTime _dateModified;
        private string _description;
        private EffectivePrivacyEnum _effectivePrivacy;
        private EffectiveSecurityTypeEnum _effectiveSecurityType;
        private CaptionEntity _formattedValues;
        private bool _hasChildren;
        private bool _hideOwner;
        private string _highlightImageUri;
        private bool _isRoot;
        private string[] _keywords;
        private string _name;
        private string _nodeID;
        private string _password;
        private string _passwordHint;
        private PrivacyEnum _privacy;
        private bool _resetUrlName;
        private string _responseLevel;
        private SecurityTypeEnum _securityType;
        private SmugSearchableEnum _smugSearchable;
        private SortDirectionEnum _sortDirection;
        private long _sortIndex;
        private SortMethodEnum _sortMethod;
        private TypeEnum _type;
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


        public EffectivePrivacyEnum EffectivePrivacy {
            get {
                return _effectivePrivacy;
            }
            set {
                if (_effectivePrivacy != value)
                {
                    NotifyPropertyValueChanged("EffectivePrivacy", oldValue:_effectivePrivacy, newValue: value);
                    _effectivePrivacy = value;     
                }
            }
        }


        public EffectiveSecurityTypeEnum EffectiveSecurityType {
            get {
                return _effectiveSecurityType;
            }
            set {
                if (_effectiveSecurityType != value)
                {
                    NotifyPropertyValueChanged("EffectiveSecurityType", oldValue:_effectiveSecurityType, newValue: value);
                    _effectiveSecurityType = value;     
                }
            }
        }


        public CaptionEntity FormattedValues {
            get {
                return _formattedValues;
            }
            set {
                if (_formattedValues != value)
                {
                    NotifyPropertyValueChanged("FormattedValues", oldValue:_formattedValues, newValue: value);
                    _formattedValues = value;     
                }
            }
        }


        public bool HasChildren {
            get {
                return _hasChildren;
            }
            set {
                if (_hasChildren != value)
                {
                    NotifyPropertyValueChanged("HasChildren", oldValue:_hasChildren, newValue: value);
                    _hasChildren = value;     
                }
            }
        }


        public bool HideOwner {
            get {
                return _hideOwner;
            }
            set {
                if (_hideOwner != value)
                {
                    NotifyPropertyValueChanged("HideOwner", oldValue:_hideOwner, newValue: value);
                    _hideOwner = value;     
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


        public bool IsRoot {
            get {
                return _isRoot;
            }
            set {
                if (_isRoot != value)
                {
                    NotifyPropertyValueChanged("IsRoot", oldValue:_isRoot, newValue: value);
                    _isRoot = value;     
                }
            }
        }


        public string[] Keywords {
            get {
                return _keywords;
            }
            set {
                if (_keywords != value)
                {
                    NotifyPropertyValueChanged("Keywords", oldValue:_keywords, newValue: value);
                    _keywords = value;     
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


        public string NodeID {
            get {
                return _nodeID;
            }
            set {
                if (_nodeID != value)
                {
                    NotifyPropertyValueChanged("NodeID", oldValue:_nodeID, newValue: value);
                    _nodeID = value;     
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


        public bool ResetUrlName {
            get {
                return _resetUrlName;
            }
            set {
                if (_resetUrlName != value)
                {
                    NotifyPropertyValueChanged("ResetUrlName", oldValue:_resetUrlName, newValue: value);
                    _resetUrlName = value;     
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


        public SmugSearchableEnum SmugSearchable {
            get {
                return _smugSearchable;
            }
            set {
                if (_smugSearchable != value)
                {
                    NotifyPropertyValueChanged("SmugSearchable", oldValue:_smugSearchable, newValue: value);
                    _smugSearchable = value;     
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
                    NotifyPropertyValueChanged("SortDirection", oldValue:_sortDirection, newValue: value);
                    _sortDirection = value;     
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


        public SortMethodEnum SortMethod {
            get {
                return _sortMethod;
            }
            set {
                if (_sortMethod != value)
                {
                    NotifyPropertyValueChanged("SortMethod", oldValue:_sortMethod, newValue: value);
                    _sortMethod = value;     
                }
            }
        }


        public TypeEnum Type {
            get {
                return _type;
            }
            set {
                if (_type != value)
                {
                    NotifyPropertyValueChanged("Type", oldValue:_type, newValue: value);
                    _type = value;     
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


        public string WebUri {
            get {
                return _webUri;
            }
            set {
                if (_webUri != value)
                {
                    NotifyPropertyValueChanged("WebUri", oldValue:_webUri, newValue: value);
                    _webUri = value;     
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
                    NotifyPropertyValueChanged("WorldSearchable", oldValue:_worldSearchable, newValue: value);
                    _worldSearchable = value;     
                }
            }
        }
    }
}
