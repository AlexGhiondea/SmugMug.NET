// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class CSMILVideoEntity : SmugMugEntity
    {
        private string _url;


        public string Url {
            get {
                return _url;
            }
            set {
                if (_url != value)
                {
                    NotifyPropertyValueChanged("Url", oldValue:_url, newValue: value);
                    _url = value;     
                }
            }
        }
    }
}
