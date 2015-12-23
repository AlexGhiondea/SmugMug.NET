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
                    NotifyPropertyValueChanged("Autorun", oldValue:_autorun, newValue: value);
                    _autorun = value;     
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
                    NotifyPropertyValueChanged("Complete", oldValue:_complete, newValue: value);
                    _complete = value;     
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
