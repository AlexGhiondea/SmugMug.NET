// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

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
                    _creationDate = value;
                    NotifyPropertyValueChanged("CreationDate", _creationDate);
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
                    _guideID = value;
                    NotifyPropertyValueChanged("GuideID", _guideID);
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
