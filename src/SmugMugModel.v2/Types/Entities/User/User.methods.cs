// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public FolderEntity folderuser___ (string param1)
        {
            // /folder/user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}", param1);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return RetrieveEntityAsync<NodeEntity>(requestUri).Result; 
        }

        public AlbumEntity[] user____albums (string param1)
        {
            // /user/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!albums", param1);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public AlbumTemplateEntity[] user____albumtemplates (string param1)
        {
            // /user/(*)!albumtemplates 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!albumtemplates", param1);

            return RetrieveEntityArrayAsync<AlbumTemplateEntity>(requestUri).Result; 
        }

        public BioImageEntity user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!bioimage", param1);

            return RetrieveEntityAsync<BioImageEntity>(requestUri).Result; 
        }

        public ContactEntity[] user____contacts (string param1)
        {
            // /user/(*)!contacts 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!contacts", param1);

            return RetrieveEntityArrayAsync<ContactEntity>(requestUri).Result; 
        }

        public UserCouponEntity[] user____coupons (string param1)
        {
            // /user/(*)!coupons 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!coupons", param1);

            return RetrieveEntityArrayAsync<UserCouponEntity>(requestUri).Result; 
        }

        public CoverImageEntity user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!coverimage", param1);

            return RetrieveEntityAsync<CoverImageEntity>(requestUri).Result; 
        }

        public DeletedAlbumEntity[] user____deletedalbums (string param1)
        {
            // /user/(*)!deletedalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedalbums", param1);

            return RetrieveEntityArrayAsync<DeletedAlbumEntity>(requestUri).Result; 
        }

        public DeletedFolderEntity[] user____deletedfolders (string param1)
        {
            // /user/(*)!deletedfolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedfolders", param1);

            return RetrieveEntityArrayAsync<DeletedFolderEntity>(requestUri).Result; 
        }

        public DeletedPageEntity[] user____deletedpages (string param1)
        {
            // /user/(*)!deletedpages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!deletedpages", param1);

            return RetrieveEntityArrayAsync<DeletedPageEntity>(requestUri).Result; 
        }

        public ImageEntity[] user____duplicateimagesearch (string param1)
        {
            // /user/(*)!duplicateimagesearch 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!duplicateimagesearch", param1);

            return RetrieveEntityArrayAsync<ImageEntity>(requestUri).Result; 
        }

        public AlbumEntity[] user____featuredalbums (string param1)
        {
            // /user/(*)!featuredalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!featuredalbums", param1);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FeaturesEntity user____features (string param1)
        {
            // /user/(*)!features 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!features", param1);

            return RetrieveEntityAsync<FeaturesEntity>(requestUri).Result; 
        }

        public ImageEntity[] user____geomedia (string param1)
        {
            // /user/(*)!geomedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!geomedia", param1);

            return RetrieveEntityArrayAsync<ImageEntity>(requestUri).Result; 
        }

        public GrantEntity[] user____grants (string param1)
        {
            // /user/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!grants", param1);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public UserGuideStateEntity[] user____guides (string param1)
        {
            // /user/(*)!guides 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!guides", param1);

            return RetrieveEntityArrayAsync<UserGuideStateEntity>(requestUri).Result; 
        }

        public UserHideGuidesEntity user____hideguides (string param1)
        {
            // /user/(*)!hideguides 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!hideguides", param1);

            return RetrieveEntityAsync<UserHideGuidesEntity>(requestUri).Result; 
        }

        public ImageEntity[] user____imagesearch (string param1)
        {
            // /user/(*)!imagesearch 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!imagesearch", param1);

            return RetrieveEntityArrayAsync<ImageEntity>(requestUri).Result; 
        }

        public QuickNewsEntity[] user____latestquicknews (string param1)
        {
            // /user/(*)!latestquicknews 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!latestquicknews", param1);

            return RetrieveEntityArrayAsync<QuickNewsEntity>(requestUri).Result; 
        }

        public ImageEntity[] user____popularmedia (string param1)
        {
            // /user/(*)!popularmedia 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!popularmedia", param1);

            return RetrieveEntityArrayAsync<ImageEntity>(requestUri).Result; 
        }

        public PrintmarkEntity[] user____printmarks (string param1)
        {
            // /user/(*)!printmarks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!printmarks", param1);

            return RetrieveEntityArrayAsync<PrintmarkEntity>(requestUri).Result; 
        }

        public UserProfileEntity user____profile (string param1)
        {
            // /user/(*)!profile 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!profile", param1);

            return RetrieveEntityAsync<UserProfileEntity>(requestUri).Result; 
        }

        public ImageEntity[] user____recentimages (string param1)
        {
            // /user/(*)!recentimages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!recentimages", param1);

            return RetrieveEntityArrayAsync<ImageEntity>(requestUri).Result; 
        }

        public void user____sortfeaturedalbums (string param1)
        {
            // /user/(*)!sortfeaturedalbums 
            return; 
        }

        public TaskEntity[] user____tasks (string param1)
        {
            // /user/(*)!tasks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!tasks", param1);

            return RetrieveEntityArrayAsync<TaskEntity>(requestUri).Result; 
        }

        public UserTopKeywordsEntity user____topkeywords (string param1)
        {
            // /user/(*)!topkeywords 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!topkeywords", param1);

            return RetrieveEntityAsync<UserTopKeywordsEntity>(requestUri).Result; 
        }

        public UserUploadLimitsEntity user____uploadlimits (string param1)
        {
            // /user/(*)!uploadlimits 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!uploadlimits", param1);

            return RetrieveEntityAsync<UserUploadLimitsEntity>(requestUri).Result; 
        }

        public FolderAlbumPageEntity user____urlpathlookup (string param1)
        {
            // /user/(*)!urlpathlookup 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!urlpathlookup", param1);

            return RetrieveEntityAsync<FolderAlbumPageEntity>(requestUri).Result; 
        }

        public WatermarkEntity[] user____watermarks (string param1)
        {
            // /user/(*)!watermarks 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}!watermarks", param1);

            return RetrieveEntityArrayAsync<WatermarkEntity>(requestUri).Result; 
        }
    }
}
