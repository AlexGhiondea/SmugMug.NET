// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ContactEmailEntity : SmugMugEntity
    {
        private string _email;


        public string Email {
            get {
                return _email;
            }
            set {
                if (_email != value)
                {
                    NotifyPropertyValueChanged("Email", oldValue:_email, newValue: value);
                    _email = value;     
                }
            }
        }
    }
}
