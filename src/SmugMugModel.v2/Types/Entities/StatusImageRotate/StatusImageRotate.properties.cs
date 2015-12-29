// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class StatusImageRotateEntity : StatusEntity
    {
        private long _degrees;
        private long _rotate;

        public long Degrees {
            get {
                return _degrees;
            }
            set {
                if (_degrees != value)
                {
                    NotifyPropertyValueChanged("Degrees", oldValue:_degrees, newValue: value);
                    _degrees = value;     
                }
            }
        }

        public long Rotate {
            get {
                return _rotate;
            }
            set {
                if (_rotate != value)
                {
                    NotifyPropertyValueChanged("Rotate", oldValue:_rotate, newValue: value);
                    _rotate = value;     
                }
            }
        }
    }
}
