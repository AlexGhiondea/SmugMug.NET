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
        private int _imageCount;
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
                    _accountStatus = value;
                    NotifyPropertyValueChanged("AccountStatus", _accountStatus);
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
                    _domain = value;
                    NotifyPropertyValueChanged("Domain", _domain);
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
                    _domainOnly = value;
                    NotifyPropertyValueChanged("DomainOnly", _domainOnly);
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
                    _firstName = value;
                    NotifyPropertyValueChanged("FirstName", _firstName);
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
                    _friendsView = value;
                    NotifyPropertyValueChanged("FriendsView", _friendsView);
                }
            }
        }


        public int ImageCount {
            get {
                return _imageCount;
            }
            set {
                if (_imageCount != value)
                {
                    _imageCount = value;
                    NotifyPropertyValueChanged("ImageCount", _imageCount);
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
                    _isTrial = value;
                    NotifyPropertyValueChanged("IsTrial", _isTrial);
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
                    _lastName = value;
                    NotifyPropertyValueChanged("LastName", _lastName);
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


        public string NickName {
            get {
                return _nickName;
            }
            set {
                if (_nickName != value)
                {
                    _nickName = value;
                    NotifyPropertyValueChanged("NickName", _nickName);
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
                    _plan = value;
                    NotifyPropertyValueChanged("Plan", _plan);
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
                    _quickShare = value;
                    NotifyPropertyValueChanged("QuickShare", _quickShare);
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
                    _refTag = value;
                    NotifyPropertyValueChanged("RefTag", _refTag);
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


        public SortByEnum SortBy {
            get {
                return _sortBy;
            }
            set {
                if (_sortBy != value)
                {
                    _sortBy = value;
                    NotifyPropertyValueChanged("SortBy", _sortBy);
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
                    _totalAccountSize = value;
                    NotifyPropertyValueChanged("TotalAccountSize", _totalAccountSize);
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
                    _totalUploadedSize = value;
                    NotifyPropertyValueChanged("TotalUploadedSize", _totalUploadedSize);
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


        public string ViewPassHint {
            get {
                return _viewPassHint;
            }
            set {
                if (_viewPassHint != value)
                {
                    _viewPassHint = value;
                    NotifyPropertyValueChanged("ViewPassHint", _viewPassHint);
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
                    _viewPassword = value;
                    NotifyPropertyValueChanged("ViewPassword", _viewPassword);
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
    }
}
