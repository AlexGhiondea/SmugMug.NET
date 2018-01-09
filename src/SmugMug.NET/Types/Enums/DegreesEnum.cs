// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using System.Runtime.Serialization;
namespace SmugMug.v2.Types
{
    public enum DegreesEnum
    {
        [EnumMember(Value = "0")]
        Zero = 0,
        [EnumMember(Value = "90")]
        Ninety = 90,
        [EnumMember(Value = "180")]
        OneEighty = 180,
        [EnumMember(Value = "270")]
        TwoSeventy = 270
    }
}
