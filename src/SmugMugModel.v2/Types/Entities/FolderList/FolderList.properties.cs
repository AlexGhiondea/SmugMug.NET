// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderListEntity : SmugMugEntity
    {
        private bool _canHaveFolder;
        private string _name;
        private string _uri;
        private string _urlPath;


        public bool CanHaveFolder {
            get {
                return _canHaveFolder;
            }
            set {
                if (_canHaveFolder != value)
                {
                    NotifyPropertyValueChanged("CanHaveFolder", oldValue:_canHaveFolder, newValue: value);
                    _canHaveFolder = value;     
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
                    NotifyPropertyValueChanged("Name", oldValue:_name, newValue: value);
                    _name = value;     
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


        public string UrlPath {
            get {
                return _urlPath;
            }
            set {
                if (_urlPath != value)
                {
                    NotifyPropertyValueChanged("UrlPath", oldValue:_urlPath, newValue: value);
                    _urlPath = value;     
                }
            }
        }
    }
}
