// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {

        public BioImageEntity user____bioimage ()
        {
            // /user/(*)!bioimage 
            return default(BioImageEntity); 
        }

        public CoverImageEntity user____coverimage ()
        {
            // /user/(*)!coverimage 
            return default(CoverImageEntity); 
        }

        public UserProfileEntity user____profile ()
        {
            // /user/(*)!profile 
            return default(UserProfileEntity); 
        }

        public NodeEntity node___ ()
        {
            // /node/(*) 
            return default(NodeEntity); 
        }

        public FolderEntity folderuser___ ()
        {
            // /folder/user/(*) 
            return default(FolderEntity); 
        }

        public AlbumEntity user____albums ()
        {
            // /user/(*)!albums 
            return default(AlbumEntity); 
        }

        public ImageEntity user____geomedia ()
        {
            // /user/(*)!geomedia 
            return default(ImageEntity); 
        }

        public ImageEntity user____popularmedia ()
        {
            // /user/(*)!popularmedia 
            return default(ImageEntity); 
        }

        public AlbumEntity user____featuredalbums ()
        {
            // /user/(*)!featuredalbums 
            return default(AlbumEntity); 
        }

        public ImageEntity user____recentimages ()
        {
            // /user/(*)!recentimages 
            return default(ImageEntity); 
        }

        public ImageEntity user____imagesearch ()
        {
            // /user/(*)!imagesearch 
            return default(ImageEntity); 
        }

        public UserTopKeywordsEntity user____topkeywords ()
        {
            // /user/(*)!topkeywords 
            return default(UserTopKeywordsEntity); 
        }

        public FolderAlbumPageEntity user____urlpathlookup ()
        {
            // /user/(*)!urlpathlookup 
            return default(FolderAlbumPageEntity); 
        }

        public AlbumTemplateEntity user____albumtemplates ()
        {
            // /user/(*)!albumtemplates 
            return default(AlbumTemplateEntity); 
        }

        public void user____sortfeaturedalbums ()
        {
            // /user/(*)!sortfeaturedalbums 
             
        }

        public TaskEntity user____tasks ()
        {
            // /user/(*)!tasks 
            return default(TaskEntity); 
        }

        public WatermarkEntity user____watermarks ()
        {
            // /user/(*)!watermarks 
            return default(WatermarkEntity); 
        }

        public PrintmarkEntity user____printmarks ()
        {
            // /user/(*)!printmarks 
            return default(PrintmarkEntity); 
        }

        public UserUploadLimitsEntity user____uploadlimits ()
        {
            // /user/(*)!uploadlimits 
            return default(UserUploadLimitsEntity); 
        }

        public UserCouponEntity user____coupons ()
        {
            // /user/(*)!coupons 
            return default(UserCouponEntity); 
        }

        public QuickNewsEntity user____latestquicknews ()
        {
            // /user/(*)!latestquicknews 
            return default(QuickNewsEntity); 
        }

        public UserGuideStateEntity user____guides ()
        {
            // /user/(*)!guides 
            return default(UserGuideStateEntity); 
        }

        public UserHideGuidesEntity user____hideguides ()
        {
            // /user/(*)!hideguides 
            return default(UserHideGuidesEntity); 
        }

        public FeaturesEntity user____features ()
        {
            // /user/(*)!features 
            return default(FeaturesEntity); 
        }

        public GrantEntity user____grants ()
        {
            // /user/(*)!grants 
            return default(GrantEntity); 
        }

        public ImageEntity user____duplicateimagesearch ()
        {
            // /user/(*)!duplicateimagesearch 
            return default(ImageEntity); 
        }

        public DeletedAlbumEntity user____deletedalbums ()
        {
            // /user/(*)!deletedalbums 
            return default(DeletedAlbumEntity); 
        }

        public DeletedFolderEntity user____deletedfolders ()
        {
            // /user/(*)!deletedfolders 
            return default(DeletedFolderEntity); 
        }

        public DeletedPageEntity user____deletedpages ()
        {
            // /user/(*)!deletedpages 
            return default(DeletedPageEntity); 
        }

        public ContactEntity user____contacts ()
        {
            // /user/(*)!contacts 
            return default(ContactEntity); 
        }

    }
}
