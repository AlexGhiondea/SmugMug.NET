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


        public BioImageEntity user____bioimage (string param1)
        {
            // /user/(*)!bioimage 
            return default(BioImageEntity); 
        }

        public CoverImageEntity user____coverimage (string param1)
        {
            // /user/(*)!coverimage 
            return default(CoverImageEntity); 
        }

        public UserProfileEntity user____profile (string param1)
        {
            // /user/(*)!profile 
            return default(UserProfileEntity); 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            return default(NodeEntity); 
        }

        public FolderEntity folderuser___ (string param1)
        {
            // /folder/user/(*) 
            return default(FolderEntity); 
        }

        public AlbumEntity[] user____albums (string param1)
        {
            // /user/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public ImageEntity[] user____geomedia (string param1)
        {
            // /user/(*)!geomedia 
            return default(ImageEntity[]); 
        }

        public ImageEntity[] user____popularmedia (string param1)
        {
            // /user/(*)!popularmedia 
            return default(ImageEntity[]); 
        }

        public AlbumEntity[] user____featuredalbums (string param1)
        {
            // /user/(*)!featuredalbums 
            return default(AlbumEntity[]); 
        }

        public ImageEntity[] user____recentimages (string param1)
        {
            // /user/(*)!recentimages 
            return default(ImageEntity[]); 
        }

        public ImageEntity[] user____imagesearch (string param1)
        {
            // /user/(*)!imagesearch 
            return default(ImageEntity[]); 
        }

        public UserTopKeywordsEntity user____topkeywords (string param1)
        {
            // /user/(*)!topkeywords 
            return default(UserTopKeywordsEntity); 
        }

        public FolderAlbumPageEntity user____urlpathlookup (string param1)
        {
            // /user/(*)!urlpathlookup 
            return default(FolderAlbumPageEntity); 
        }

        public AlbumTemplateEntity[] user____albumtemplates (string param1)
        {
            // /user/(*)!albumtemplates 
            return default(AlbumTemplateEntity[]); 
        }

        public void user____sortfeaturedalbums (string param1)
        {
            // /user/(*)!sortfeaturedalbums 
             
        }

        public TaskEntity[] user____tasks (string param1)
        {
            // /user/(*)!tasks 
            return default(TaskEntity[]); 
        }

        public WatermarkEntity[] user____watermarks (string param1)
        {
            // /user/(*)!watermarks 
            return default(WatermarkEntity[]); 
        }

        public PrintmarkEntity[] user____printmarks (string param1)
        {
            // /user/(*)!printmarks 
            return default(PrintmarkEntity[]); 
        }

        public UserUploadLimitsEntity user____uploadlimits (string param1)
        {
            // /user/(*)!uploadlimits 
            return default(UserUploadLimitsEntity); 
        }

        public UserCouponEntity[] user____coupons (string param1)
        {
            // /user/(*)!coupons 
            return default(UserCouponEntity[]); 
        }

        public QuickNewsEntity[] user____latestquicknews (string param1)
        {
            // /user/(*)!latestquicknews 
            return default(QuickNewsEntity[]); 
        }

        public UserGuideStateEntity[] user____guides (string param1)
        {
            // /user/(*)!guides 
            return default(UserGuideStateEntity[]); 
        }

        public UserHideGuidesEntity user____hideguides (string param1)
        {
            // /user/(*)!hideguides 
            return default(UserHideGuidesEntity); 
        }

        public FeaturesEntity user____features (string param1)
        {
            // /user/(*)!features 
            return default(FeaturesEntity); 
        }

        public GrantEntity[] user____grants (string param1)
        {
            // /user/(*)!grants 
            return default(GrantEntity[]); 
        }

        public ImageEntity[] user____duplicateimagesearch (string param1)
        {
            // /user/(*)!duplicateimagesearch 
            return default(ImageEntity[]); 
        }

        public DeletedAlbumEntity[] user____deletedalbums (string param1)
        {
            // /user/(*)!deletedalbums 
            return default(DeletedAlbumEntity[]); 
        }

        public DeletedFolderEntity[] user____deletedfolders (string param1)
        {
            // /user/(*)!deletedfolders 
            return default(DeletedFolderEntity[]); 
        }

        public DeletedPageEntity[] user____deletedpages (string param1)
        {
            // /user/(*)!deletedpages 
            return default(DeletedPageEntity[]); 
        }

        public ContactEntity[] user____contacts (string param1)
        {
            // /user/(*)!contacts 
            return default(ContactEntity[]); 
        }
    }
}
