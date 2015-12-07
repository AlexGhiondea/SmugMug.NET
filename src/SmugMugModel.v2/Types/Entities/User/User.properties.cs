// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        public AccountStatusEnum AccountStatus {get; set;}
        public string Domain {get; set;}
        public string DomainOnly {get; set;}
        public string FirstName {get; set;}
        public bool FriendsView {get; set;}
        public int ImageCount {get; set;}
        public bool IsTrial {get; set;}
        public string LastName {get; set;}
        public string Name {get; set;}
        public string NickName {get; set;}
        public string Plan {get; set;}
        public bool QuickShare {get; set;}
        public string RefTag {get; set;}
        public string ResponseLevel {get; set;}
        public SortByEnum SortBy {get; set;}
        public string TotalAccountSize {get; set;}
        public string TotalUploadedSize {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public string ViewPassHint {get; set;}
        public string ViewPassword {get; set;}
        public string WebUri {get; set;}

    }
}
