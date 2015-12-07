// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class StatusImageColorEntity : SmugMugEntity
    {
        public ColorEnum Color {get; set;}
        public string ImageUri {get; set;}
        public DateTime LastUpdated {get; set;}
        public string Message {get; set;}
        public string QueueName {get; set;}
        public ImageStatusEnum Status {get; set;}
        public DateTime TimeIn {get; set;}

    }
}
