// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class CommentEntity : SmugMugEntity
    {
        public string Comment {get; set;}
        public DateTime Date {get; set;}
        public string Name {get; set;}
        public int Rating {get; set;}
        public int ServiceID {get; set;}
        public int SocialID {get; set;}
        public CommentStatusEnum Status {get; set;}

    }
}
