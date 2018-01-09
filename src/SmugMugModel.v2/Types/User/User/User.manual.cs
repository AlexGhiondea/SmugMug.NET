// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;
using SmugMug.v2.Utility;
using System.Collections.Generic;

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

        // TODO: it is unclear if this is still needed.
        [Obsolete]
        public async Task<FolderEntity> GetFolderAsync()
        {
            // /folder/user/(*) 
            return await folderuser___(NickName);
        }

        public async Task<NodeEntity> AsNodeAsync()
        {
            return await node___(this.NodeId);
        }

        public async Task<NodeEntity> GetNodeAsync(string nodeId)
        {
            // /node/(*) 
            return await node___(nodeId);
        }

        public async Task<AlbumEntity[]> GetAlbumsAsync()
        {
            // /user/(*)!albums 
            return await user____albums(NickName);
        }

        public async Task<AlbumTemplateEntity[]> GetAlbumTemplatesAsync()
        {
            // /user/(*)!albumtemplates 
            return await user____albumtemplates(NickName);
        }

        public async Task<ImageEntity> GetBioImageAsync()
        {
            // /user/(*)!bioimage 
            return await user____bioimage(NickName);
        }

        public async Task<ContactEntity[]> GetContactsAsync()
        {
            // /user/(*)!contacts 
            return await user____contacts(NickName);
        }

        public async Task<UserCouponEntity[]> GetCouponsAsync()
        {
            // /user/(*)!coupons 
            return await user____coupons(NickName);
        }

        public async Task<ImageEntity> GetCoverImageAsync()
        {
            // /user/(*)!coverimage 
            return await user____coverimage(NickName);
        }

        public async Task<DeletedAlbumEntity[]> GetDeletedAlbumsAsync()
        {
            // /user/(*)!deletedalbums 
            return await user____deletedalbums(NickName);
        }

        public async Task<DeletedFolderEntity[]> GetDeletedFoldersAsync()
        {
            // /user/(*)!deletedfolders 
            return await user____deletedfolders(NickName);
        }

        public async Task<DeletedPageEntity[]> GetDeletedPagesAsync()
        {
            // /user/(*)!deletedpages 
            return await user____deletedpages(NickName);
        }

        public async Task<ImageEntity[]> GetDuplicateImageSearchAsync()
        {
            // /user/(*)!duplicateimagesearch 
            return await user____duplicateimagesearch(NickName);
        }

        public async Task<AlbumEntity[]> GetFeaturedAlbumsAsync()
        {
            // /user/(*)!featuredalbums 
            return await user____featuredalbums(NickName);
        }

        public async Task<FeaturesEntity> GetFeaturesAsync()
        {
            // /user/(*)!features 
            return await user____features(NickName);
        }

        public async Task<ImageEntity[]> GetGeoMediaAsync()
        {
            // /user/(*)!geomedia 
            return await user____geomedia(NickName);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /user/(*)!grants 
            return await user____grants(NickName);
        }

        public async Task<UserGuideStateEntity[]> GetGuidesAsync()
        {
            // /user/(*)!guides 
            return await user____guides(NickName);
        }

        public async Task<UserHideGuidesEntity> GetHideGuidesAsync()
        {
            // /user/(*)!hideguides 
            return await user____hideguides(NickName);
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
            return await user____latestquicknews(NickName);
        }

        public async Task<ImageEntity[]> GetPopularMediaAsync()
        {
            // /user/(*)!popularmedia 
            return await user____popularmedia(NickName);
        }

        public async Task<PrintmarkEntity[]> GetPrintMarksAsync()
        {
            // /user/(*)!printmarks 
            return await user____printmarks(NickName);
        }

        public async Task<UserProfileEntity> GetProfileAsync()
        {
            // /user/(*)!profile 
            return await user____profile(NickName);
        }

        public async Task<ImageEntity[]> GetRecentImagesAsync()
        {
            // /user/(*)!recentimages 
            return await user____recentimages(NickName);
        }

        public async Task RequiresPost_Fixup_user____sortfeaturedalbums()
        {
            // /user/(*)!sortfeaturedalbums 
            await user____sortfeaturedalbums(NickName);
        }

        public async Task<TaskEntity[]> GetTasksAsync()
        {
            // /user/(*)!tasks 
            return await user____tasks(NickName);
        }

        public async Task<UserTopKeywordsEntity> GetTopKeywordsAsync()
        {
            // /user/(*)!topkeywords 
            return await user____topkeywords(NickName);
        }

        public async Task<UserUploadLimitsEntity[]> GetUploadLimitsAsync()
        {
            // /user/(*)!uploadlimits 
            return await user____uploadlimits(NickName);
        }

        //public async Task<FolderAlbumPageEntity> RequiresPost_Fixup_user____urlpathlookup()
        //{
        //    // /user/(*)!urlpathlookup 
        //    return await user____urlpathlookup(string.Empty);
        //}

        public async Task<WatermarkEntity[]> GetWatermarksAsync()
        {
            // /user/(*)!watermarks 
            return await user____watermarks(NickName);
        }
    }
}
