// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserGuideStateEntity : SmugMugEntity
    {
        private bool _autorun;
        private bool _complete;
        private string _uri;
        private string _uriDescription;


        public bool Autorun {
            get {
                return _autorun;
            }
            set {
                if (_autorun != value)
                {
                    _autorun = value;
                    NotifyPropertyValueChanged("Autorun", _autorun);
                }
            }
        }


        public bool Complete {
            get {
                return _complete;
            }
            set {
                if (_complete != value)
                {
                    _complete = value;
                    NotifyPropertyValueChanged("Complete", _complete);
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
