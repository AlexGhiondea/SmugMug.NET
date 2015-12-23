// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserUploadLimitsEntity : SmugMugEntity
    {
        private long _maxPixels;
        private long _maxSize;
        private string _mimeTypes;
        private string _type;


        public long MaxPixels {
            get {
                return _maxPixels;
            }
            set {
                if (_maxPixels != value)
                {
                    NotifyPropertyValueChanged("MaxPixels", oldValue:_maxPixels, newValue: value);
                    _maxPixels = value;     
                }
            }
        }


        public long MaxSize {
            get {
                return _maxSize;
            }
            set {
                if (_maxSize != value)
                {
                    NotifyPropertyValueChanged("MaxSize", oldValue:_maxSize, newValue: value);
                    _maxSize = value;     
                }
            }
        }


        public string MimeTypes {
            get {
                return _mimeTypes;
            }
            set {
                if (_mimeTypes != value)
                {
                    NotifyPropertyValueChanged("MimeTypes", oldValue:_mimeTypes, newValue: value);
                    _mimeTypes = value;     
                }
            }
        }


        public string Type {
            get {
                return _type;
            }
            set {
                if (_type != value)
                {
                    NotifyPropertyValueChanged("Type", oldValue:_type, newValue: value);
                    _type = value;     
                }
            }
        }
    }
}
