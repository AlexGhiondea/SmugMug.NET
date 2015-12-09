// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class UserHideGuidesEntity : SmugMugEntity
    {
        private bool _hide;
        private string _uri;
        private string _uriDescription;


        public bool Hide {
            get {
                return _hide;
            }
            set {
                if (_hide != value)
                {
                    _hide = value;
                    NotifyPropertyValueChanged("Hide", _hide);
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
