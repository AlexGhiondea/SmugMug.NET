// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserHideGuidesEntity : SmugMugEntity
    {
        private bool _hide;


        public bool Hide {
            get {
                return _hide;
            }
            set {
                if (_hide != value)
                {
                    NotifyPropertyValueChanged("Hide", oldValue:_hide, newValue: value);
                    _hide = value;     
                }
            }
        }
    }
}
