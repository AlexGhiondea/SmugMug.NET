// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using System.Runtime.Serialization;

namespace SmugMug.v2.Types
{
    public enum LargestSizeEnum 
    {
        Medium,
        Large,
        XLarge,
        X2Large,
        X3Large,
        X4Large,
        Original,
        [EnumMember(Value = "5K")]
        _5K,
        [EnumMember(Value = "4K")]
        _4K
    }
}
