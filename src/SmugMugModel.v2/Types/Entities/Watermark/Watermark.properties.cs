// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class WatermarkEntity : SmugMugEntity
    {
        private long _dissolve;
        private long _imageID;
        private string _imageKey;
        private string _name;
        private PinnedEnum _pinned;
        private SmallestSizeEnum _smallestSize;
        private bool _thumbs;
        private string _uri;
        private string _uriDescription;
        private long _watermarkID;


        public long Dissolve {
            get {
                return _dissolve;
            }
            set {
                if (_dissolve != value)
                {
                    _dissolve = value;
                    NotifyPropertyValueChanged("Dissolve", _dissolve);
                }
            }
        }


        public long ImageID {
            get {
                return _imageID;
            }
            set {
                if (_imageID != value)
                {
                    _imageID = value;
                    NotifyPropertyValueChanged("ImageID", _imageID);
                }
            }
        }


        public string ImageKey {
            get {
                return _imageKey;
            }
            set {
                if (_imageKey != value)
                {
                    _imageKey = value;
                    NotifyPropertyValueChanged("ImageKey", _imageKey);
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


        public PinnedEnum Pinned {
            get {
                return _pinned;
            }
            set {
                if (_pinned != value)
                {
                    _pinned = value;
                    NotifyPropertyValueChanged("Pinned", _pinned);
                }
            }
        }


        public SmallestSizeEnum SmallestSize {
            get {
                return _smallestSize;
            }
            set {
                if (_smallestSize != value)
                {
                    _smallestSize = value;
                    NotifyPropertyValueChanged("SmallestSize", _smallestSize);
                }
            }
        }


        public bool Thumbs {
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


        public long WatermarkID {
            get {
                return _watermarkID;
            }
            set {
                if (_watermarkID != value)
                {
                    _watermarkID = value;
                    NotifyPropertyValueChanged("WatermarkID", _watermarkID);
                }
            }
        }
    }
}
