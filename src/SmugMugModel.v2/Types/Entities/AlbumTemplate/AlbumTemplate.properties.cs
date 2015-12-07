// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumTemplateEntity : SmugMugEntity
    {
        public bool AllowDownloads {get; set;}
        public string Backprinting {get; set;}
        public BoutiquePackagingEnum BoutiquePackaging {get; set;}
        public bool CanRank {get; set;}
        public bool Clean {get; set;}
        public bool Comments {get; set;}
        public string CommunityUri {get; set;}
        public bool EXIF {get; set;}
        public bool External {get; set;}
        public bool FamilyEdit {get; set;}
        public bool Filenames {get; set;}
        public bool FriendEdit {get; set;}
        public bool Geography {get; set;}
        public HeaderEnum Header {get; set;}
        public bool HideOwner {get; set;}
        public InterceptShippingEnum InterceptShipping {get; set;}
        public LargestSizeEnum LargestSize {get; set;}
        public string Name {get; set;}
        public bool PackagingBranding {get; set;}
        public string Password {get; set;}
        public string PasswordHint {get; set;}
        public bool Printable {get; set;}
        public string PrintmarkUri {get; set;}
        public int ProofDays {get; set;}
        public bool Protected {get; set;}
        public bool Public {get; set;}
        public bool Share {get; set;}
        public SmugSearchableEnum SmugSearchable {get; set;}
        public SortDirectionEnum SortDirection {get; set;}
        public SortMethodEnum SortMethod {get; set;}
        public bool SquareThumbs {get; set;}
        public string TemplateUri {get; set;}
        public bool Watermark {get; set;}
        public string WatermarkUri {get; set;}
        public bool WorldSearchable {get; set;}

    }
}
