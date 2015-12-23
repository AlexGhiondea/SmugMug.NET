// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class GuideEntity : SmugMugEntity
    {
        private string _creationDate;
        private string _guideID;
        private string _uri;
        private string _uriDescription;


        public string CreationDate {
            get {
                return _creationDate;
            }
            set {
                if (_creationDate != value)
                {
                    NotifyPropertyValueChanged("CreationDate", oldValue:_creationDate, newValue: value);
                    _creationDate = value;     
                }
            }
        }


        public string GuideID {
            get {
                return _guideID;
            }
            set {
                if (_guideID != value)
                {
                    NotifyPropertyValueChanged("GuideID", oldValue:_guideID, newValue: value);
                    _guideID = value;     
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
    }
}
