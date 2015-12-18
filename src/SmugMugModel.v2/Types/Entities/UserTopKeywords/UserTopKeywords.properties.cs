// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserTopKeywordsEntity : SmugMugEntity
    {
        private string[] _topKeywords;
        private string _uri;
        private string _uriDescription;


        public string[] TopKeywords {
            get {
                return _topKeywords;
            }
            set {
                if (_topKeywords != value)
                {
                    _topKeywords = value;
                    NotifyPropertyValueChanged("TopKeywords", _topKeywords);
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
