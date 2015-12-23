// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ThemeEntity : SmugMugEntity
    {
        private BaseColorEnum _baseColor;
        private string _category;
        private string _creator;
        private string _creatorURL;
        private DateTime _lastUpdated;
        private string _name;
        private bool _stretchy;
        private string _theme;


        public BaseColorEnum BaseColor {
            get {
                return _baseColor;
            }
            set {
                if (_baseColor != value)
                {
                    NotifyPropertyValueChanged("BaseColor", oldValue:_baseColor, newValue: value);
                    _baseColor = value;     
                }
            }
        }


        public string Category {
            get {
                return _category;
            }
            set {
                if (_category != value)
                {
                    NotifyPropertyValueChanged("Category", oldValue:_category, newValue: value);
                    _category = value;     
                }
            }
        }


        public string Creator {
            get {
                return _creator;
            }
            set {
                if (_creator != value)
                {
                    NotifyPropertyValueChanged("Creator", oldValue:_creator, newValue: value);
                    _creator = value;     
                }
            }
        }


        public string CreatorURL {
            get {
                return _creatorURL;
            }
            set {
                if (_creatorURL != value)
                {
                    NotifyPropertyValueChanged("CreatorURL", oldValue:_creatorURL, newValue: value);
                    _creatorURL = value;     
                }
            }
        }


        public DateTime LastUpdated {
            get {
                return _lastUpdated;
            }
            set {
                if (_lastUpdated != value)
                {
                    NotifyPropertyValueChanged("LastUpdated", oldValue:_lastUpdated, newValue: value);
                    _lastUpdated = value;     
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


        public bool Stretchy {
            get {
                return _stretchy;
            }
            set {
                if (_stretchy != value)
                {
                    NotifyPropertyValueChanged("Stretchy", oldValue:_stretchy, newValue: value);
                    _stretchy = value;     
                }
            }
        }


        public string Theme {
            get {
                return _theme;
            }
            set {
                if (_theme != value)
                {
                    NotifyPropertyValueChanged("Theme", oldValue:_theme, newValue: value);
                    _theme = value;     
                }
            }
        }
    }
}
