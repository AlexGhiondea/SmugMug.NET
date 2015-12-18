// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CSMILVideoEntity : SmugMugEntity
    {
        private string _uri;
        private string _uriDescription;
        private string _url;


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


        public string Url {
            get {
                return _url;
            }
            set {
                if (_url != value)
                {
                    _url = value;
                    NotifyPropertyValueChanged("Url", _url);
                }
            }
        }
    }
}
