// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserProfileEntity : SmugMugEntity
    {
        private string _bioImageUri;
        private string _bioText;
        private string _blogger;
        private string _coverImageUri;
        private string _custom;
        private string _displayName;
        private string _facebook;
        private string _firstName;
        private string _flickr;
        private string _googlePlus;
        private string _instagram;
        private string _lastName;
        private string _linkedIn;
        private string _pinterest;
        private string _responseLevel;
        private string _tumblr;
        private string _twitter;
        private string _uri;
        private string _uriDescription;
        private string _vimeo;
        private string _wordpress;
        private string _youTube;


        public string BioImageUri {
            get {
                return _bioImageUri;
            }
            set {
                if (_bioImageUri != value)
                {
                    _bioImageUri = value;
                    NotifyPropertyValueChanged("BioImageUri", _bioImageUri);
                }
            }
        }


        public string BioText {
            get {
                return _bioText;
            }
            set {
                if (_bioText != value)
                {
                    _bioText = value;
                    NotifyPropertyValueChanged("BioText", _bioText);
                }
            }
        }


        public string Blogger {
            get {
                return _blogger;
            }
            set {
                if (_blogger != value)
                {
                    _blogger = value;
                    NotifyPropertyValueChanged("Blogger", _blogger);
                }
            }
        }


        public string CoverImageUri {
            get {
                return _coverImageUri;
            }
            set {
                if (_coverImageUri != value)
                {
                    _coverImageUri = value;
                    NotifyPropertyValueChanged("CoverImageUri", _coverImageUri);
                }
            }
        }


        public string Custom {
            get {
                return _custom;
            }
            set {
                if (_custom != value)
                {
                    _custom = value;
                    NotifyPropertyValueChanged("Custom", _custom);
                }
            }
        }


        public string DisplayName {
            get {
                return _displayName;
            }
            set {
                if (_displayName != value)
                {
                    _displayName = value;
                    NotifyPropertyValueChanged("DisplayName", _displayName);
                }
            }
        }


        public string Facebook {
            get {
                return _facebook;
            }
            set {
                if (_facebook != value)
                {
                    _facebook = value;
                    NotifyPropertyValueChanged("Facebook", _facebook);
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


        public string Flickr {
            get {
                return _flickr;
            }
            set {
                if (_flickr != value)
                {
                    _flickr = value;
                    NotifyPropertyValueChanged("Flickr", _flickr);
                }
            }
        }


        public string GooglePlus {
            get {
                return _googlePlus;
            }
            set {
                if (_googlePlus != value)
                {
                    _googlePlus = value;
                    NotifyPropertyValueChanged("GooglePlus", _googlePlus);
                }
            }
        }


        public string Instagram {
            get {
                return _instagram;
            }
            set {
                if (_instagram != value)
                {
                    _instagram = value;
                    NotifyPropertyValueChanged("Instagram", _instagram);
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


        public string LinkedIn {
            get {
                return _linkedIn;
            }
            set {
                if (_linkedIn != value)
                {
                    _linkedIn = value;
                    NotifyPropertyValueChanged("LinkedIn", _linkedIn);
                }
            }
        }


        public string Pinterest {
            get {
                return _pinterest;
            }
            set {
                if (_pinterest != value)
                {
                    _pinterest = value;
                    NotifyPropertyValueChanged("Pinterest", _pinterest);
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


        public string Tumblr {
            get {
                return _tumblr;
            }
            set {
                if (_tumblr != value)
                {
                    _tumblr = value;
                    NotifyPropertyValueChanged("Tumblr", _tumblr);
                }
            }
        }


        public string Twitter {
            get {
                return _twitter;
            }
            set {
                if (_twitter != value)
                {
                    _twitter = value;
                    NotifyPropertyValueChanged("Twitter", _twitter);
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


        public string Vimeo {
            get {
                return _vimeo;
            }
            set {
                if (_vimeo != value)
                {
                    _vimeo = value;
                    NotifyPropertyValueChanged("Vimeo", _vimeo);
                }
            }
        }


        public string Wordpress {
            get {
                return _wordpress;
            }
            set {
                if (_wordpress != value)
                {
                    _wordpress = value;
                    NotifyPropertyValueChanged("Wordpress", _wordpress);
                }
            }
        }


        public string YouTube {
            get {
                return _youTube;
            }
            set {
                if (_youTube != value)
                {
                    _youTube = value;
                    NotifyPropertyValueChanged("YouTube", _youTube);
                }
            }
        }
    }
}
