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


        private static readonly List<string> PatchParameters = new List<string>(){ "Name","CommunityUri","PrintmarkUri","WatermarkUri","TemplateUri","AllowDownloads","Backprinting","BoutiquePackaging","CanRank","Clean","Comments","EXIF","External","FamilyEdit","Filenames","FriendEdit","Geography","Header","HideOwner","InterceptShipping","LargestSize","PackagingBranding","Password","PasswordHint","Printable","ProofDays","Protected","Public","Share","SmugSearchable","SortDirection","SortMethod","SquareThumbs","Watermark","WorldSearchable" };

        private static readonly List<string> PostParameters = new List<string>(){ "Name", "CommunityUri", "PrintmarkUri", "WatermarkUri", "TemplateUri", "AllowDownloads", "Backprinting", "BoutiquePackaging", "CanRank", "Clean", "Comments", "EXIF", "External", "FamilyEdit", "Filenames", "FriendEdit", "Geography", "Header", "HideOwner", "InterceptShipping", "LargestSize", "PackagingBranding", "Password", "PasswordHint", "Printable", "ProofDays", "Protected", "Public", "Share", "SmugSearchable", "SortDirection", "SortMethod", "SquareThumbs", "Watermark", "WorldSearchable" };


        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
