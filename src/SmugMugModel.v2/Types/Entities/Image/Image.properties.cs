// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class ImageEntity : SmugMugEntity
    {
        public int Altitude {get; set;}
        public string ArchivedMD5 {get; set;}
        public int ArchivedSize {get; set;}
        public string ArchivedUri {get; set;}
        public bool CanEdit {get; set;}
        public string Caption {get; set;}
        public bool Collectable {get; set;}
        public DateTime Date {get; set;}
        public bool EZProject {get; set;}
        public string FileName {get; set;}
        public string Format {get; set;}
        public string FormattedValues {get; set;}
        public bool Hidden {get; set;}
        public string ImageKey {get; set;}
        public bool IsArchive {get; set;}
        public bool IsVideo {get; set;}
        public string[] KeywordArray {get; set;}
        public string Keywords {get; set;}
        public DateTime LastUpdated {get; set;}
        public decimal Latitude {get; set;}
        public decimal Longitude {get; set;}
        public int OriginalHeight {get; set;}
        public int OriginalSize {get; set;}
        public int OriginalWidth {get; set;}
        public bool Processing {get; set;}
        public bool Protected {get; set;}
        public string ThumbnailUrl {get; set;}
        public string Title {get; set;}
        public string UploadKey {get; set;}
        public string Uri {get; set;}
        public string UriDescription {get; set;}
        public WatermarkEnum Watermark {get; set;}
        public bool Watermarked {get; set;}
        public string WebUri {get; set;}

    }
}
