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


        private async Task<FolderEntity> folderuser___ (string param1)
        {
            // /folder/user/(*) 
            string requestUri = string.Format("{0}/folder/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        private async Task<NodeEntity> node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("{0}/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            var node = await RetrieveEntityAsync<NodeEntity>(requestUri);
            node.NodeId = param1;
            return node;
        }

        private async Task<AlbumEntity[]> user____albums (string param1)
        {
            // /user/(*)!albums 
            string requestUri = string.Format("{0}/user/{1}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        private async Task<AlbumTemplateEntity[]> user____albumtemplates (string param1)
        {
            // /user/(*)!albumtemplates 
            string requestUri = string.Format("{0}/user/{1}!albumtemplates", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<AlbumTemplateEntity>(requestUri); 
        }

        private async Task<ImageEntity> user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            string requestUri = string.Format("{0}/user/{1}!bioimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        private async Task<ContactEntity[]> user____contacts (string param1)
        {
            // /user/(*)!contacts 
            string requestUri = string.Format("{0}/user/{1}!contacts", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ContactEntity>(requestUri); 
        }

        private async Task<UserCouponEntity[]> user____coupons (string param1)
        {
            // /user/(*)!coupons 
            string requestUri = string.Format("{0}/user/{1}!coupons", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<UserCouponEntity>(requestUri); 
        }

        private async Task<ImageEntity> user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("{0}/user/{1}!coverimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        private async Task<DeletedAlbumEntity[]> user____deletedalbums (string param1)
        {
            // /user/(*)!deletedalbums 
            string requestUri = string.Format("{0}/user/{1}!deletedalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<DeletedAlbumEntity>(requestUri); 
        }

        private async Task<DeletedFolderEntity[]> user____deletedfolders (string param1)
        {
            // /user/(*)!deletedfolders 
            string requestUri = string.Format("{0}/user/{1}!deletedfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<DeletedFolderEntity>(requestUri); 
        }

        private async Task<DeletedPageEntity[]> user____deletedpages (string param1)
        {
            // /user/(*)!deletedpages 
            string requestUri = string.Format("{0}/user/{1}!deletedpages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<DeletedPageEntity>(requestUri); 
        }

        private async Task<ImageEntity[]> user____duplicateimagesearch (string param1)
        {
            // /user/(*)!duplicateimagesearch 
            string requestUri = string.Format("{0}/user/{1}!duplicateimagesearch", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        private async Task<AlbumEntity[]> user____featuredalbums (string param1)
        {
            // /user/(*)!featuredalbums 
            string requestUri = string.Format("{0}/user/{1}!featuredalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        private async Task<FeaturesEntity> user____features (string param1)
        {
            // /user/(*)!features 
            string requestUri = string.Format("{0}/user/{1}!features", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<FeaturesEntity>(requestUri); 
        }

        private async Task<ImageEntity[]> user____geomedia (string param1)
        {
            // /user/(*)!geomedia 
            string requestUri = string.Format("{0}/user/{1}!geomedia", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        private async Task<GrantEntity[]> user____grants (string param1)
        {
            // /user/(*)!grants 
            string requestUri = string.Format("{0}/user/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        private async Task<UserGuideStateEntity[]> user____guides (string param1)
        {
            // /user/(*)!guides 
            string requestUri = string.Format("{0}/user/{1}!guides", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<UserGuideStateEntity>(requestUri); 
        }

        private async Task<UserHideGuidesEntity> user____hideguides (string param1)
        {
            // /user/(*)!hideguides 
            string requestUri = string.Format("{0}/user/{1}!hideguides", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserHideGuidesEntity>(requestUri); 
        }

        private async Task<ImageEntity[]> user____imagesearch (string param1)
        {
            // /user/(*)!imagesearch 
            string requestUri = string.Format("{0}/user/{1}!imagesearch", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        private async Task<QuickNewsEntity[]> user____latestquicknews (string param1)
        {
            // /user/(*)!latestquicknews 
            string requestUri = string.Format("{0}/user/{1}!latestquicknews", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<QuickNewsEntity>(requestUri); 
        }

        private async Task<ImageEntity[]> user____popularmedia (string param1)
        {
            // /user/(*)!popularmedia 
            string requestUri = string.Format("{0}/user/{1}!popularmedia", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        private async Task<PrintmarkEntity[]> user____printmarks (string param1)
        {
            // /user/(*)!printmarks 
            string requestUri = string.Format("{0}/user/{1}!printmarks", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<PrintmarkEntity>(requestUri); 
        }

        private async Task<UserProfileEntity> user____profile (string param1)
        {
            // /user/(*)!profile 
            string requestUri = string.Format("{0}/user/{1}!profile", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserProfileEntity>(requestUri); 
        }

        private async Task<ImageEntity[]> user____recentimages (string param1)
        {
            // /user/(*)!recentimages 
            string requestUri = string.Format("{0}/user/{1}!recentimages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }

        private async Task user____sortfeaturedalbums (string param1)
        {
            // /user/(*)!sortfeaturedalbums 
            string requestUri = string.Format("{0}/user/{1}!sortfeaturedalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        private async Task<TaskEntity[]> user____tasks (string param1)
        {
            // /user/(*)!tasks 
            string requestUri = string.Format("{0}/user/{1}!tasks", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<TaskEntity>(requestUri); 
        }

        private async Task<UserTopKeywordsEntity> user____topkeywords (string param1)
        {
            // /user/(*)!topkeywords 
            string requestUri = string.Format("{0}/user/{1}!topkeywords", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserTopKeywordsEntity>(requestUri); 
        }

        private async Task<UserUploadLimitsEntity[]> user____uploadlimits (string param1)
        {
            // /user/(*)!uploadlimits 
            string requestUri = string.Format("{0}/user/{1}!uploadlimits", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<UserUploadLimitsEntity>(requestUri); 
        }

        //private async Task<FolderAlbumPageEntity> user____urlpathlookup (string param1)
        //{
        //    // /user/(*)!urlpathlookup 
        //    string requestUri = string.Format("{0}/user/{1}!urlpathlookup", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

        //    return await RetrieveEntityAsync<FolderAlbumPageEntity>(requestUri); 
        //}

        private async Task<WatermarkEntity[]> user____watermarks (string param1)
        {
            // /user/(*)!watermarks 
            string requestUri = string.Format("{0}/user/{1}!watermarks", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<WatermarkEntity>(requestUri); 
        }
    }
}
