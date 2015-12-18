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
                    _baseColor = value;
                    NotifyPropertyValueChanged("BaseColor", _baseColor);
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
                    _category = value;
                    NotifyPropertyValueChanged("Category", _category);
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
                    _creator = value;
                    NotifyPropertyValueChanged("Creator", _creator);
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
                    _creatorURL = value;
                    NotifyPropertyValueChanged("CreatorURL", _creatorURL);
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
                    _lastUpdated = value;
                    NotifyPropertyValueChanged("LastUpdated", _lastUpdated);
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


        public bool Stretchy {
            get {
                return _stretchy;
            }
            set {
                if (_stretchy != value)
                {
                    _stretchy = value;
                    NotifyPropertyValueChanged("Stretchy", _stretchy);
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
                    _theme = value;
                    NotifyPropertyValueChanged("Theme", _theme);
                }
            }
        }
    }
}
