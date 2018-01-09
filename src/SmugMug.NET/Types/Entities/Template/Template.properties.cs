// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class TemplateEntity : SmugMugEntity
    {
        private bool _ajaxEnabled;
        private bool _cSSVer;
        private bool _dark;
        private string _filename;
        private string _name;
        private long _thumbs;


        public bool AjaxEnabled {
            get {
                return _ajaxEnabled;
            }
            set {
                if (_ajaxEnabled != value)
                {
                    NotifyPropertyValueChanged("AjaxEnabled", oldValue:_ajaxEnabled, newValue: value);
                    _ajaxEnabled = value;     
                }
            }
        }


        public bool CSSVer {
            get {
                return _cSSVer;
            }
            set {
                if (_cSSVer != value)
                {
                    NotifyPropertyValueChanged("CSSVer", oldValue:_cSSVer, newValue: value);
                    _cSSVer = value;     
                }
            }
        }


        public bool Dark {
            get {
                return _dark;
            }
            set {
                if (_dark != value)
                {
                    NotifyPropertyValueChanged("Dark", oldValue:_dark, newValue: value);
                    _dark = value;     
                }
            }
        }


        public string Filename {
            get {
                return _filename;
            }
            set {
                if (_filename != value)
                {
                    NotifyPropertyValueChanged("Filename", oldValue:_filename, newValue: value);
                    _filename = value;     
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


        public long Thumbs {
            get {
                return _thumbs;
            }
            set {
                if (_thumbs != value)
                {
                    NotifyPropertyValueChanged("Thumbs", oldValue:_thumbs, newValue: value);
                    _thumbs = value;     
                }
            }
        }
    }
}
