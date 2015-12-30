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
                    NotifyPropertyValueChanged("BioImageUri", oldValue:_bioImageUri, newValue: value);
                    _bioImageUri = value;     
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
                    NotifyPropertyValueChanged("BioText", oldValue:_bioText, newValue: value);
                    _bioText = value;     
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
                    NotifyPropertyValueChanged("Blogger", oldValue:_blogger, newValue: value);
                    _blogger = value;     
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
                    NotifyPropertyValueChanged("CoverImageUri", oldValue:_coverImageUri, newValue: value);
                    _coverImageUri = value;     
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
                    NotifyPropertyValueChanged("Custom", oldValue:_custom, newValue: value);
                    _custom = value;     
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
                    NotifyPropertyValueChanged("DisplayName", oldValue:_displayName, newValue: value);
                    _displayName = value;     
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
                    NotifyPropertyValueChanged("Facebook", oldValue:_facebook, newValue: value);
                    _facebook = value;     
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


        public string Flickr {
            get {
                return _flickr;
            }
            set {
                if (_flickr != value)
                {
                    NotifyPropertyValueChanged("Flickr", oldValue:_flickr, newValue: value);
                    _flickr = value;     
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
                    NotifyPropertyValueChanged("GooglePlus", oldValue:_googlePlus, newValue: value);
                    _googlePlus = value;     
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
                    NotifyPropertyValueChanged("Instagram", oldValue:_instagram, newValue: value);
                    _instagram = value;     
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


        public string LinkedIn {
            get {
                return _linkedIn;
            }
            set {
                if (_linkedIn != value)
                {
                    NotifyPropertyValueChanged("LinkedIn", oldValue:_linkedIn, newValue: value);
                    _linkedIn = value;     
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
                    NotifyPropertyValueChanged("Pinterest", oldValue:_pinterest, newValue: value);
                    _pinterest = value;     
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


        public string Tumblr {
            get {
                return _tumblr;
            }
            set {
                if (_tumblr != value)
                {
                    NotifyPropertyValueChanged("Tumblr", oldValue:_tumblr, newValue: value);
                    _tumblr = value;     
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
                    NotifyPropertyValueChanged("Twitter", oldValue:_twitter, newValue: value);
                    _twitter = value;     
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
                    NotifyPropertyValueChanged("Vimeo", oldValue:_vimeo, newValue: value);
                    _vimeo = value;     
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
                    NotifyPropertyValueChanged("Wordpress", oldValue:_wordpress, newValue: value);
                    _wordpress = value;     
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
                    NotifyPropertyValueChanged("YouTube", oldValue:_youTube, newValue: value);
                    _youTube = value;     
                }
            }
        }
    }
}
