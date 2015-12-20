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
                    _maxPixels = value;
                    NotifyPropertyValueChanged("MaxPixels", _maxPixels);
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
                    _maxSize = value;
                    NotifyPropertyValueChanged("MaxSize", _maxSize);
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
                    _mimeTypes = value;
                    NotifyPropertyValueChanged("MimeTypes", _mimeTypes);
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
                    _type = value;
                    NotifyPropertyValueChanged("Type", _type);
                }
            }
        }
    }
}
