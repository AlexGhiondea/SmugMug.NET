// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {
        public string AlbumKey {get; set;}
        public bool AllowDownloads {get; set;}
        public bool AutoRename {get; set;}
        public string Backprinting {get; set;}
        public BoutiquePackagingEnum BoutiquePackaging {get; set;}
        public bool CanRank {get; set;}
        public bool CanShare {get; set;}
        public bool Clean {get; set;}
        public bool Comments {get; set;}
        public string CommunityUri {get; set;}
        public DateTime Date {get; set;}
        public string Description {get; set;}
        public string DownloadPassword {get; set;}
        public bool EXIF {get; set;}
        public bool External {get; set;}
        public bool FamilyEdit {get; set;}
        public bool Filenames {get; set;}
        public bool FriendEdit {get; set;}
        public bool Geography {get; set;}
        public bool HasDownloadPassword {get; set;}
        public HeaderEnum Header {get; set;}
        public bool HideOwner {get; set;}
        public string HighlightAlbumImageUri {get; set;}
        public int ImageCount {get; set;}
        public DateTime ImagesLastUpdated {get; set;}
        public InterceptShippingEnum InterceptShipping {get; set;}
        public string Keywords {get; set;}
        public LargestSizeEnum LargestSize {get; set;}
        public DateTime LastUpdated {get; set;}
        public string Name {get; set;}
        public string NiceName {get; set;}
        public string NodeID {get; set;}
        public int OriginalSizes {get; set;}
        public bool PackagingBranding {get; set;}
        public string Password {get; set;}
        public string PasswordHint {get; set;}
        public bool Printable {get; set;}
        public string PrintmarkUri {get; set;}
        public PrivacyEnum Privacy {get; set;}
        public int ProofDays {get; set;}
        public bool Protected {get; set;}
        public string ResponseLevel {get; set;}
        public SecurityTypeEnum SecurityType {get; set;}
        public bool Share {get; set;}
        public SmugSearchableEnum SmugSearchable {get; set;}
        public SortDirectionEnum SortDirection {get; set;}
        public SortMethodEnum SortMethod {get; set;}
        public bool SquareThumbs {get; set;}
        public string TemplateUri {get; set;}
        public string ThemeUri {get; set;}
        public string Title {get; set;}
        public int TotalSizes {get; set;}
        public string UploadKey {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public string UrlName {get; set;}
        public string UrlPath {get; set;}
        public bool Watermark {get; set;}
        public string WatermarkUri {get; set;}
        public string WebUri {get; set;}
        public bool WorldSearchable {get; set;}

    }
}
