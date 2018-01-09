// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ContactEntity : SmugMugEntity
    {
        private string _name;
        private string _primaryEmail;


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


        public string PrimaryEmail {
            get {
                return _primaryEmail;
            }
            set {
                if (_primaryEmail != value)
                {
                    NotifyPropertyValueChanged("PrimaryEmail", oldValue:_primaryEmail, newValue: value);
                    _primaryEmail = value;     
                }
            }
        }
    }
}
