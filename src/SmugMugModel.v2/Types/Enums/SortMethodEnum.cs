// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System.Runtime.Serialization;

namespace SmugMug.v2.Types
{
    public enum SortMethodEnum 
    {
        SortIndex,
        Name,
        DateAdded,
        [EnumMember(Value="Date Modified")]
        DateModified,
        Position,
        Caption,
        Filename,
        [EnumMember(Value="Date Uploaded")]
        DateUploaded,
        [EnumMember(Value="Date Taken")]
        DateTaken
    }
}
