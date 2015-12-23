// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        private AccountStatusEnum _accountStatus;
        private string _domain;
        private string _domainOnly;
        private string _firstName;
        private bool _friendsView;
        private long _imageCount;
        private bool _isTrial;
        private string _lastName;
        private string _name;
        private string _nickName;
        private string _plan;
        private bool _quickShare;
        private string _refTag;
        private string _responseLevel;
        private SortByEnum _sortBy;
        private string _totalAccountSize;
        private string _totalUploadedSize;
        private string _uri;
        private string _uriDescription;
        private string _viewPassHint;
        private string _viewPassword;
        private string _webUri;


        public AccountStatusEnum AccountStatus {
            get {
                return _accountStatus;
            }
            set {
                if (_accountStatus != value)
                {
                    NotifyPropertyValueChanged("AccountStatus", oldValue:_accountStatus, newValue: value);
                    _accountStatus = value;     
                }
            }
        }


        public string Domain {
            get {
                return _domain;
            }
            set {
                if (_domain != value)
                {
                    NotifyPropertyValueChanged("Domain", oldValue:_domain, newValue: value);
                    _domain = value;     
                }
            }
        }


        public string DomainOnly {
            get {
                return _domainOnly;
            }
            set {
                if (_domainOnly != value)
                {
                    NotifyPropertyValueChanged("DomainOnly", oldValue:_domainOnly, newValue: value);
                    _domainOnly = value;     
                }
            }
        }


        public string FirstName {
            get {
                return _firstName;
            }
            set {
                if (_firstName != value)
                {
                    NotifyPropertyValueChanged("FirstName", oldValue:_firstName, newValue: value);
                    _firstName = value;     
                }
            }
        }


        public bool FriendsView {
            get {
                return _friendsView;
            }
            set {
                if (_friendsView != value)
                {
                    NotifyPropertyValueChanged("FriendsView", oldValue:_friendsView, newValue: value);
                    _friendsView = value;     
                }
            }
        }


        public long ImageCount {
            get {
                return _imageCount;
            }
            set {
                if (_imageCount != value)
                {
                    NotifyPropertyValueChanged("ImageCount", oldValue:_imageCount, newValue: value);
                    _imageCount = value;     
                }
            }
        }


        public bool IsTrial {
            get {
                return _isTrial;
            }
            set {
                if (_isTrial != value)
                {
                    NotifyPropertyValueChanged("IsTrial", oldValue:_isTrial, newValue: value);
                    _isTrial = value;     
                }
            }
        }


        public string LastName {
            get {
                return _lastName;
            }
            set {
                if (_lastName != value)
                {
                    NotifyPropertyValueChanged("LastName", oldValue:_lastName, newValue: value);
                    _lastName = value;     
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


        public string NickName {
            get {
                return _nickName;
            }
            set {
                if (_nickName != value)
                {
                    NotifyPropertyValueChanged("NickName", oldValue:_nickName, newValue: value);
                    _nickName = value;     
                }
            }
        }


        public string Plan {
            get {
                return _plan;
            }
            set {
                if (_plan != value)
                {
                    NotifyPropertyValueChanged("Plan", oldValue:_plan, newValue: value);
                    _plan = value;     
                }
            }
        }


        public bool QuickShare {
            get {
                return _quickShare;
            }
            set {
                if (_quickShare != value)
                {
                    NotifyPropertyValueChanged("QuickShare", oldValue:_quickShare, newValue: value);
                    _quickShare = value;     
                }
            }
        }


        public string RefTag {
            get {
                return _refTag;
            }
            set {
                if (_refTag != value)
                {
                    NotifyPropertyValueChanged("RefTag", oldValue:_refTag, newValue: value);
                    _refTag = value;     
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


        public SortByEnum SortBy {
            get {
                return _sortBy;
            }
            set {
                if (_sortBy != value)
                {
                    NotifyPropertyValueChanged("SortBy", oldValue:_sortBy, newValue: value);
                    _sortBy = value;     
                }
            }
        }


        public string TotalAccountSize {
            get {
                return _totalAccountSize;
            }
            set {
                if (_totalAccountSize != value)
                {
                    NotifyPropertyValueChanged("TotalAccountSize", oldValue:_totalAccountSize, newValue: value);
                    _totalAccountSize = value;     
                }
            }
        }


        public string TotalUploadedSize {
            get {
                return _totalUploadedSize;
            }
            set {
                if (_totalUploadedSize != value)
                {
                    NotifyPropertyValueChanged("TotalUploadedSize", oldValue:_totalUploadedSize, newValue: value);
                    _totalUploadedSize = value;     
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


        public string ViewPassHint {
            get {
                return _viewPassHint;
            }
            set {
                if (_viewPassHint != value)
                {
                    NotifyPropertyValueChanged("ViewPassHint", oldValue:_viewPassHint, newValue: value);
                    _viewPassHint = value;     
                }
            }
        }


        public string ViewPassword {
            get {
                return _viewPassword;
            }
            set {
                if (_viewPassword != value)
                {
                    NotifyPropertyValueChanged("ViewPassword", oldValue:_viewPassword, newValue: value);
                    _viewPassword = value;     
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
    }
}
