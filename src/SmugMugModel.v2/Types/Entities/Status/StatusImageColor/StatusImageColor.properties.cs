// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class StatusImageColorEntity : StatusImageEntity
    {
        private ColorEnum _color;

        public ColorEnum Color {
            get {
                return _color;
            }
            set {
                if (_color != value)
                {
                    NotifyPropertyValueChanged("Color", oldValue:_color, newValue: value);
                    _color = value;     
                }
            }
        }
    }
}
