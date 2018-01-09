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
        private long _watermarkID;


        public long Dissolve {
            get {
                return _dissolve;
            }
            set {
                if (_dissolve != value)
                {
                    NotifyPropertyValueChanged("Dissolve", oldValue:_dissolve, newValue: value);
                    _dissolve = value;     
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
                    NotifyPropertyValueChanged("ImageID", oldValue:_imageID, newValue: value);
                    _imageID = value;     
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
                    NotifyPropertyValueChanged("ImageKey", oldValue:_imageKey, newValue: value);
                    _imageKey = value;     
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


        public PinnedEnum Pinned {
            get {
                return _pinned;
            }
            set {
                if (_pinned != value)
                {
                    NotifyPropertyValueChanged("Pinned", oldValue:_pinned, newValue: value);
                    _pinned = value;     
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
                    NotifyPropertyValueChanged("SmallestSize", oldValue:_smallestSize, newValue: value);
                    _smallestSize = value;     
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
                    NotifyPropertyValueChanged("Thumbs", oldValue:_thumbs, newValue: value);
                    _thumbs = value;     
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
                    NotifyPropertyValueChanged("WatermarkID", oldValue:_watermarkID, newValue: value);
                    _watermarkID = value;     
                }
            }
        }
    }
}
