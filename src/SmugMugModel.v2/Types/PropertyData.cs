// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMug.v2.Types
{
    internal class PropertyData
    {
        public object OldValue { get; set; }
        public object NewValue { get; set; }

        public PropertyData(object oldValue, object newValue)
        {
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }
    }
}
