// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserTopKeywordsEntity : SmugMugEntity
    {
        private string[] _topKeywords;


        public string[] TopKeywords {
            get {
                return _topKeywords;
            }
            set {
                if (_topKeywords != value)
                {
                    NotifyPropertyValueChanged("TopKeywords", oldValue:_topKeywords, newValue: value);
                    _topKeywords = value;     
                }
            }
        }
    }
}
