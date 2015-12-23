// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Runtime.Serialization;

namespace SmugMug.v2.Types
{
    public enum BoutiquePackagingEnum 
    {
        No,
        Yes,
        [EnumMember(Value="Inherit from User")]
        InheritfromUser
    }
}
