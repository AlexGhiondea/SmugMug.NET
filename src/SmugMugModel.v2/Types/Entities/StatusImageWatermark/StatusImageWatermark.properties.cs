// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class StatusImageWatermarkEntity : StatusEntity
    {
        private string _watermarkUri;

        public string WatermarkUri {
            get {
                return _watermarkUri;
            }
            set {
                if (_watermarkUri != value)
                {
                    NotifyPropertyValueChanged("WatermarkUri", oldValue:_watermarkUri, newValue: value);
                    _watermarkUri = value;     
                }
            }
        }
    }
}
