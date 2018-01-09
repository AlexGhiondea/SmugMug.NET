// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {
        public AlbumEntity()
        {
            //Empty constructor to enable deserialization
        }

        public AlbumEntity(OAuthToken oauthToken)
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

        private static readonly List<string> PatchParameters = new List<string>(){ "NiceName","UrlName","Title","Name","CommunityUri","PrintmarkUri","WatermarkUri","ThemeUri","TemplateUri","AllowDownloads","Backprinting","BoutiquePackaging","CanRank","Clean","Comments","Description","DownloadPassword","EXIF","External","FamilyEdit","Filenames","FriendEdit","Geography","Header","HideOwner","InterceptShipping","Keywords","LargestSize","PackagingBranding","Password","PasswordHint","Printable","Privacy","ProofDays","Protected","Share","SmugSearchable","SortDirection","SortMethod","SquareThumbs","UploadKey","Watermark","WorldSearchable","AutoRename","SecurityType","HighlightAlbumImageUri" };

        private static readonly List<string> PostParameters = new List<string>(){ "NiceName", "UrlName", "Title", "Name", "CommunityUri", "PrintmarkUri", "WatermarkUri", "ThemeUri", "TemplateUri", "AllowDownloads", "Backprinting", "BoutiquePackaging", "CanRank", "Clean", "Comments", "Description", "DownloadPassword", "EXIF", "External", "FamilyEdit", "Filenames", "FriendEdit", "Geography", "Header", "HideOwner", "InterceptShipping", "Keywords", "LargestSize", "PackagingBranding", "Password", "PasswordHint", "Printable", "Privacy", "ProofDays", "Protected", "Share", "SmugSearchable", "SortDirection", "SortMethod", "SquareThumbs", "UploadKey", "Watermark", "WorldSearchable", "AutoRename", "SecurityType", "AlbumUri" };


        private async Task<ApplyAlbumTemplateEntity> album____applyalbumtemplate (string param1)
        {
            // /album/(*)!applyalbumtemplate 
            string requestUri = string.Format("{0}/album/{1}!applyalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ApplyAlbumTemplateEntity>(requestUri); 
        }

        private async Task album____collectimages (string param1)
        {
            // /album/(*)!collectimages 
            string requestUri = string.Format("{0}/album/{1}!collectimages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task album____deleteimages (string param1)
        {
            // /album/(*)!deleteimages 
            string requestUri = string.Format("{0}/album/{1}!deleteimages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task<ImageEntity> album____highlightimage (string param1)
        {
            // /album/(*)!highlightimage 
            string requestUri = string.Format("{0}/album/{1}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        private async Task album____moveimages (string param1)
        {
            // /album/(*)!moveimages 
            string requestUri = string.Format("{0}/album/{1}!moveimages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task album____uploadfromuri (string param1)
        {
            // /album/(*)!uploadfromuri 
            string requestUri = string.Format("{0}/album/{1}!uploadfromuri", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task<FolderEntity[]> folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity> folderuser___albumName___ (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*) 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity[]> folderuser___albumName____parents (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity> folderuser___Family___ (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*) 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity[]> folderuser___Family____parents (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity> folderuser___SmugMug___ (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*) 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        private async Task<FolderEntity[]> folderuser___SmugMug____parents (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }
    }
}
