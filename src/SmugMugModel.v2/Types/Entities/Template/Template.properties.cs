// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class TemplateEntity : SmugMugEntity
    {
        private bool _ajaxEnabled;
        private bool _cSSVer;
        private bool _dark;
        private string _filename;
        private string _name;
        private int _thumbs;


        public bool AjaxEnabled {
            get {
                return _ajaxEnabled;
            }
            set {
                if (_ajaxEnabled != value)
                {
                    _ajaxEnabled = value;
                    NotifyPropertyValueChanged("AjaxEnabled", _ajaxEnabled);
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
                    _cSSVer = value;
                    NotifyPropertyValueChanged("CSSVer", _cSSVer);
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
                    _dark = value;
                    NotifyPropertyValueChanged("Dark", _dark);
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
                    _filename = value;
                    NotifyPropertyValueChanged("Filename", _filename);
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
                    _name = value;
                    NotifyPropertyValueChanged("Name", _name);
                }
            }
        }


        public int Thumbs {
            get {
                return _thumbs;
            }
            set {
                if (_thumbs != value)
                {
                    _thumbs = value;
                    NotifyPropertyValueChanged("Thumbs", _thumbs);
                }
            }
        }



    }
}
