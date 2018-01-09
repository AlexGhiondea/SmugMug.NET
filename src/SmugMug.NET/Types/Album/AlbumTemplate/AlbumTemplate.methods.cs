// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumTemplateEntity : SmugMugEntity
    {
        public AlbumTemplateEntity()
        {
            //Empty constructor to enable deserialization
        }

        public AlbumTemplateEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }

        protected override IEnumerable<string> GetPostPropertiesName()
        {
            return PostParameters;
        }

        protected override IEnumerable<string> GetPatchPropertiesName()
        {
            return PatchParameters;
        }

        private static readonly List<string> PatchParameters = new List<string>() { "Name", "CommunityUri", "PrintmarkUri", "WatermarkUri", "TemplateUri", "AllowDownloads", "Backprinting", "BoutiquePackaging", "CanRank", "Clean", "Comments", "EXIF", "External", "FamilyEdit", "Filenames", "FriendEdit", "Geography", "Header", "HideOwner", "InterceptShipping", "LargestSize", "PackagingBranding", "Password", "PasswordHint", "Printable", "ProofDays", "Protected", "Public", "Share", "SmugSearchable", "SortDirection", "SortMethod", "SquareThumbs", "Watermark", "WorldSearchable" };

        private static readonly List<string> PostParameters = new List<string>() { "Name", "CommunityUri", "PrintmarkUri", "WatermarkUri", "TemplateUri", "AllowDownloads", "Backprinting", "BoutiquePackaging", "CanRank", "Clean", "Comments", "EXIF", "External", "FamilyEdit", "Filenames", "FriendEdit", "Geography", "Header", "HideOwner", "InterceptShipping", "LargestSize", "PackagingBranding", "Password", "PasswordHint", "Printable", "ProofDays", "Protected", "Public", "Share", "SmugSearchable", "SortDirection", "SortMethod", "SquareThumbs", "Watermark", "WorldSearchable" };
    }
}
