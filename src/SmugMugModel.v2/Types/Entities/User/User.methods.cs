// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        public UserEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<FolderEntity> folderuser___ (string param1)
        {
            // /folder/user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}", param1);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<NodeEntity> node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return await RetrieveEntityAsync<NodeEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> user____albums (string param1)
        {
            // /user/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!albums", param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<AlbumTemplateEntity[]> user____albumtemplates (string param1)
        {
            // /user/(*)!albumtemplates 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!albumtemplates", param1);

            return await RetrieveEntityArrayAsync<AlbumTemplateEntity>(requestUri); 
        }

        public async Task<BioImageEntity> user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!bioimage", param1);

            return await RetrieveEntityAsync<BioImageEntity>(requestUri); 
        }

        public async Task<ContactEntity[]> user____contacts (string param1)
        {
            // /user/(*)!contacts 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!contacts", param1);

            return await RetrieveEntityArrayAsync<ContactEntity>(requestUri); 
        }

        public async Task<UserCouponEntity[]> user____coupons (string param1)
        {
            // /user/(*)!coupons 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!coupons", param1);

            return await RetrieveEntityArrayAsync<UserCouponEntity>(requestUri); 
        }

        public async Task<CoverImageEntity> user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!coverimage", param1);

            return await RetrieveEntityAsync<CoverImageEntity>(requestUri); 
        }

        public async Task<DeletedAlbumEntity[]> user____deletedalbums (string param1)
        {
            // /user/(*)!deletedalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedalbums", param1);

            return await RetrieveEntityArrayAsync<DeletedAlbumEntity>(requestUri); 
        }

        public async Task<DeletedFolderEntity[]> user____deletedfolders (string param1)
        {
            // /user/(*)!deletedfolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedfolders", param1);

            return await RetrieveEntityArrayAsync<DeletedFolderEntity>(requestUri); 
        }

        public async Task<DeletedPageEntity[]> user____deletedpages (string param1)
        {
            // /user/(*)!deletedpages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedpages", param1);

            return await RetrieveEntityArrayAsync<DeletedPageEntity>(requestUri); 
        }

        public async Task<ImageEntity[]> user____duplicateimagesearch (string param1)
        {
            // /user/(*)!duplicateimagesearch 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!duplicateimagesearch", param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> user____featuredalbums (string param1)
        {
            // /user/(*)!featuredalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!featuredalbums", param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FeaturesEntity> user____features (string param1)
        {
            // /user/(*)!features 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!features", param1);

            return await RetrieveEntityAsync<FeaturesEntity>(requestUri); 
        }

        public async Task<ImageEntity[]> user____geomedia (string param1)
        {
            // /user/(*)!geomedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!geomedia", param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> user____grants (string param1)
        {
            // /user/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!grants", param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<UserGuideStateEntity[]> user____guides (string param1)
        {
            // /user/(*)!guides 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!guides", param1);

            return await RetrieveEntityArrayAsync<UserGuideStateEntity>(requestUri); 
        }

        public async Task<UserHideGuidesEntity> user____hideguides (string param1)
        {
            // /user/(*)!hideguides 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!hideguides", param1);

            return await RetrieveEntityAsync<UserHideGuidesEntity>(requestUri); 
        }

        public async Task<ImageEntity[]> user____imagesearch (string param1)
        {
            // /user/(*)!imagesearch 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!imagesearch", param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        public async Task<QuickNewsEntity[]> user____latestquicknews (string param1)
        {
            // /user/(*)!latestquicknews 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!latestquicknews", param1);

            return await RetrieveEntityArrayAsync<QuickNewsEntity>(requestUri); 
        }

        public async Task<ImageEntity[]> user____popularmedia (string param1)
        {
            // /user/(*)!popularmedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!popularmedia", param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        public async Task<PrintmarkEntity[]> user____printmarks (string param1)
        {
            // /user/(*)!printmarks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!printmarks", param1);

            return await RetrieveEntityArrayAsync<PrintmarkEntity>(requestUri); 
        }

        public async Task<UserProfileEntity> user____profile (string param1)
        {
            // /user/(*)!profile 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!profile", param1);

            return await RetrieveEntityAsync<UserProfileEntity>(requestUri); 
        }

        public async Task<ImageEntity[]> user____recentimages (string param1)
        {
            // /user/(*)!recentimages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!recentimages", param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        public async Task user____sortfeaturedalbums (string param1)
        {
            // /user/(*)!sortfeaturedalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!sortfeaturedalbums", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<TaskEntity[]> user____tasks (string param1)
        {
            // /user/(*)!tasks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!tasks", param1);

            return await RetrieveEntityArrayAsync<TaskEntity>(requestUri); 
        }

        public async Task<UserTopKeywordsEntity> user____topkeywords (string param1)
        {
            // /user/(*)!topkeywords 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!topkeywords", param1);

            return await RetrieveEntityAsync<UserTopKeywordsEntity>(requestUri); 
        }

        public async Task<UserUploadLimitsEntity> user____uploadlimits (string param1)
        {
            // /user/(*)!uploadlimits 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!uploadlimits", param1);

            return await RetrieveEntityAsync<UserUploadLimitsEntity>(requestUri); 
        }

        public async Task<FolderAlbumPageEntity> user____urlpathlookup (string param1)
        {
            // /user/(*)!urlpathlookup 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!urlpathlookup", param1);

            return await RetrieveEntityAsync<FolderAlbumPageEntity>(requestUri); 
        }

        public async Task<WatermarkEntity[]> user____watermarks (string param1)
        {
            // /user/(*)!watermarks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!watermarks", param1);

            return await RetrieveEntityArrayAsync<WatermarkEntity>(requestUri); 
        }
    }
}
