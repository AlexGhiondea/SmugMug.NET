// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;
using SmugMug.v2.Utility;
using System.Collections.Generic;
using System.Linq;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        public override string EntityId
        {
            get
            {
                return NickName;
            }
        }

        private List<AlbumEntity> _albums;
        public List<AlbumEntity> AllAlbums
        {
            get
            {
                if (_albums == null)
                {
                    _albums = GetAllAlbumsAsync().Result.ToList();
                }

                return _albums;
            }
        }

        [Obsolete]
        public async Task<FolderEntity> GetFolderAsync()
        {
            // /folder/user/(*) 
            //return await folderuser___(NickName);

            // /folder/user/(*) 
            string requestUri = string.Format("{0}/folder/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<FolderEntity>(requestUri);
        }

        public async Task<NodeEntity> GetRootNodeAsync()
        {
            return await CreateNodeEntity(this.NodeId);
        }

        public async Task<NodeEntity> GetNodeAsync(string nodeId)
        {
            // /node/(*) 
            return await CreateNodeEntity(nodeId);
        }

        public async Task<AlbumEntity> GetAlbumByIdAsync(string albumId)
        {
            //https://api.smugmug.com/api/v2/album/JxG37h

            // /album/<key>
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, albumId);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri);
        }

        public async Task<AlbumEntity[]> GetAllAlbumsAsync()
        {
            // /user/(*)!albums 
            //return await user____albums(NickName);
            // /user/(*)!albums 
            string requestUri = string.Format("{0}/user/{1}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri);
        }

        public async Task<AlbumTemplateEntity[]> GetAlbumTemplatesAsync()
        {
            // /user/(*)!albumtemplates 
            //return await user____albumtemplates(NickName);

            // /user/(*)!albumtemplates 
            string requestUri = string.Format("{0}/user/{1}!albumtemplates", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<AlbumTemplateEntity>(requestUri);
        }

        public async Task<ImageEntity> GetBioImageAsync()
        {
            // /user/(*)!bioimage 
            //return await user____bioimage(NickName);

            // /user/(*)!bioimage 
            string requestUri = string.Format("{0}/user/{1}!bioimage", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }

        public async Task<ContactEntity[]> GetContactsAsync()
        {
            // /user/(*)!contacts 
            //return await user____contacts(NickName);

            // /user/(*)!contacts 
            string requestUri = string.Format("{0}/user/{1}!contacts", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<ContactEntity>(requestUri);
        }

        public async Task<UserCouponEntity[]> GetCouponsAsync()
        {
            // /user/(*)!coupons 
            //return await user____coupons(NickName);

            // /user/(*)!coupons 
            string requestUri = string.Format("{0}/user/{1}!coupons", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<UserCouponEntity>(requestUri);
        }

        public async Task<ImageEntity> GetCoverImageAsync()
        {
            // /user/(*)!coverimage 
            //return await user____coverimage(NickName);

            // /user/(*)!coverimage 
            string requestUri = string.Format("{0}/user/{1}!coverimage", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }

        public async Task<DeletedAlbumEntity[]> GetDeletedAlbumsAsync()
        {
            // /user/(*)!deletedalbums 
            // return await user____deletedalbums(NickName);

            // /user/(*)!deletedalbums 
            string requestUri = string.Format("{0}/user/{1}!deletedalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<DeletedAlbumEntity>(requestUri);
        }

        [Obsolete]
        public async Task<DeletedFolderEntity[]> GetDeletedFoldersAsync()
        {
            // /user/(*)!deletedfolders 
            //return await user____deletedfolders(NickName);

            // /user/(*)!deletedfolders 
            string requestUri = string.Format("{0}/user/{1}!deletedfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<DeletedFolderEntity>(requestUri);
        }

        public async Task<DeletedPageEntity[]> GetDeletedPagesAsync()
        {
            // /user/(*)!deletedpages 
            //return await user____deletedpages(NickName);

            // /user/(*)!deletedpages 
            string requestUri = string.Format("{0}/user/{1}!deletedpages", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<DeletedPageEntity>(requestUri);
        }

        public async Task<ImageEntity[]> GetDuplicateImageSearchAsync()
        {
            // /user/(*)!duplicateimagesearch 
            //return await user____duplicateimagesearch(NickName);

            // /user/(*)!duplicateimagesearch 
            string requestUri = string.Format("{0}/user/{1}!duplicateimagesearch", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri);
        }

        public async Task<AlbumEntity[]> GetFeaturedAlbumsAsync()
        {
            // /user/(*)!featuredalbums 
            //return await user____featuredalbums(NickName);

            // /user/(*)!featuredalbums 
            string requestUri = string.Format("{0}/user/{1}!featuredalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri);
        }

        public async Task<FeaturesEntity> GetFeaturesAsync()
        {
            // /user/(*)!features 
            //return await user____features(NickName);

            // /user/(*)!features 
            string requestUri = string.Format("{0}/user/{1}!features", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<FeaturesEntity>(requestUri);
        }

        public async Task<ImageEntity[]> GetGeoMediaAsync()
        {
            // /user/(*)!geomedia 
            string requestUri = string.Format("{0}/user/{1}!geomedia", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /user/(*)!grants 
            //return await user____grants(NickName);

            // /user/(*)!grants 
            string requestUri = string.Format("{0}/user/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri);
        }

        public async Task<UserGuideStateEntity[]> GetGuidesAsync()
        {
            // /user/(*)!guides 
            //return await user____guides(NickName);

            // /user/(*)!guides 
            string requestUri = string.Format("{0}/user/{1}!guides", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<UserGuideStateEntity>(requestUri);
        }

        public async Task<UserHideGuidesEntity> GetHideGuidesAsync()
        {
            // /user/(*)!hideguides 
            //return await user____hideguides(NickName);

            // /user/(*)!hideguides 
            string requestUri = string.Format("{0}/user/{1}!hideguides", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<UserHideGuidesEntity>(requestUri);
        }

        public async Task<ImageEntity[]> ImageSearchAsync(string text, SortDirectionEnum direction = SortDirectionEnum.Descending, ImageSearchModeEnum searchMode = ImageSearchModeEnum.Popular)
        {
            // Todo: support searching for keywords.
            string directionValue = direction.GetEnumMemberValue();
            string searchModeValue = searchMode.GetEnumMemberValue();

            //string orderValue = order.GetEnumMemberValue();
            // /user/(*)!imagesearch 
            string requestUri = string.Format("{0}/image!search?Scope={1}&SortDirection={2}&SortMethod={3}&Text={4}",
                SmugMug.v2.Constants.Addresses.SmugMugApi, this.Uri, directionValue, searchModeValue, text);


            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri);
        }

        public async Task<QuickNewsEntity[]> GetLatestQuickNewsAsync()
        {
            // /user/(*)!latestquicknews 
            //return await user____latestquicknews(NickName);

            // /user/(*)!latestquicknews 
            string requestUri = string.Format("{0}/user/{1}!latestquicknews", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<QuickNewsEntity>(requestUri);
        }

        public async Task<ImageEntity[]> GetPopularMediaAsync()
        {
            // /user/(*)!popularmedia 
            //return await user____popularmedia(NickName);

            // /user/(*)!popularmedia 
            string requestUri = string.Format("{0}/user/{1}!popularmedia", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri);
        }

        public async Task<PrintmarkEntity[]> GetPrintMarksAsync()
        {
            // /user/(*)!printmarks 
            //return await user____printmarks(NickName);

            // /user/(*)!printmarks 
            string requestUri = string.Format("{0}/user/{1}!printmarks", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<PrintmarkEntity>(requestUri);
        }

        public async Task<UserProfileEntity> GetProfileAsync()
        {
            // /user/(*)!profile 
            //return await user____profile(NickName);

            // /user/(*)!profile 
            string requestUri = string.Format("{0}/user/{1}!profile", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<UserProfileEntity>(requestUri);
        }

        public async Task<ImageEntity[]> GetRecentImagesAsync()
        {
            // /user/(*)!recentimages 
            //return await user____recentimages();

            // /user/(*)!recentimages 
            string requestUri = string.Format("{0}/user/{1}!recentimages", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri);
        }

        public async Task RequiresPost_Fixup_user____sortfeaturedalbums()
        {
            // /user/(*)!sortfeaturedalbums 
            //await user____sortfeaturedalbums(NickName);

            // /user/(*)!sortfeaturedalbums 
            string requestUri = string.Format("{0}/user/{1}!sortfeaturedalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            await GetRequestAsync(requestUri);
        }

        public async Task<TaskEntity[]> GetTasksAsync()
        {
            // /user/(*)!tasks 
            //return await user____tasks(NickName);

            // /user/(*)!tasks 
            string requestUri = string.Format("{0}/user/{1}!tasks", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<TaskEntity>(requestUri);
        }

        public async Task<UserTopKeywordsEntity> GetTopKeywordsAsync()
        {
            // /user/(*)!topkeywords 
            //return await user____topkeywords(NickName);

            // /user/(*)!topkeywords 
            string requestUri = string.Format("{0}/user/{1}!topkeywords", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityAsync<UserTopKeywordsEntity>(requestUri);
        }

        public async Task<UserUploadLimitsEntity[]> GetUploadLimitsAsync()
        {
            // /user/(*)!uploadlimits 
            //return await user____uploadlimits(NickName);

            // /user/(*)!uploadlimits 
            string requestUri = string.Format("{0}/user/{1}!uploadlimits", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<UserUploadLimitsEntity>(requestUri);
        }

        //public async Task<FolderAlbumPageEntity> RequiresPost_Fixup_user____urlpathlookup()
        //{
        //    // /user/(*)!urlpathlookup 
        //    return await user____urlpathlookup(string.Empty);
        //}

        public async Task<WatermarkEntity[]> GetWatermarksAsync()
        {
            // /user/(*)!watermarks 
            //return await user____watermarks(NickName);

            // /user/(*)!watermarks 
            string requestUri = string.Format("{0}/user/{1}!watermarks", SmugMug.v2.Constants.Addresses.SmugMugApi, NickName);

            return await RetrieveEntityArrayAsync<WatermarkEntity>(requestUri);
        }
    }
}
