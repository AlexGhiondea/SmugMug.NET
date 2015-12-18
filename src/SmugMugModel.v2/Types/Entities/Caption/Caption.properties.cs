// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class CaptionEntity : SmugMugEntity
    {
        private string _text;
        private string _html;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    NotifyPropertyValueChanged("Text", _text);
                }
            }
        }

        public string Html
        {
            get
            {
                return _html;
            }
            set
            {
                if (_html != value)
                {
                    _html = value;
                    NotifyPropertyValueChanged("Html", _html);
                }
            }
        }
    }
}
