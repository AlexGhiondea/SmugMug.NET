// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {

        public async Task<LargestImageEntity> Fixup_image____largestimage ()
        {
            // /image/(*)!largestimage 
            return await image____largestimage(string.Empty); 
        }

        public async Task<LargestVideoEntity> Fixup_image____largestvideo ()
        {
            // /image/(*)!largestvideo 
            return await image____largestvideo(string.Empty); 
        }

        public async Task<ImageSizeCustomEntity> Fixup_image____sizecustom ()
        {
            // /image/(*)!sizecustom 
            return await image____sizecustom(string.Empty); 
        }

        public async Task<ImageSizeLargeEntity> Fixup_image____sizelarge ()
        {
            // /image/(*)!sizelarge 
            return await image____sizelarge(string.Empty); 
        }

        public async Task<ImageSizeMediumEntity> Fixup_image____sizemedium ()
        {
            // /image/(*)!sizemedium 
            return await image____sizemedium(string.Empty); 
        }

        public async Task<ImageSizeSmallEntity> Fixup_image____sizesmall ()
        {
            // /image/(*)!sizesmall 
            return await image____sizesmall(string.Empty); 
        }

        public async Task<ImageSizeThumbEntity> Fixup_image____sizethumb ()
        {
            // /image/(*)!sizethumb 
            return await image____sizethumb(string.Empty); 
        }

        public async Task<ImageSizeTinyEntity> Fixup_image____sizetiny ()
        {
            // /image/(*)!sizetiny 
            return await image____sizetiny(string.Empty); 
        }

        public async Task<ImageSizeX2LargeEntity> Fixup_image____sizex2large ()
        {
            // /image/(*)!sizex2large 
            return await image____sizex2large(string.Empty); 
        }

        public async Task<ImageSizeX3LargeEntity> Fixup_image____sizex3large ()
        {
            // /image/(*)!sizex3large 
            return await image____sizex3large(string.Empty); 
        }

        public async Task<ImageSizeXLargeEntity> Fixup_image____sizexlarge ()
        {
            // /image/(*)!sizexlarge 
            return await image____sizexlarge(string.Empty); 
        }

        public async Task<ImageSizeOriginalEntity> Fixup_image____sizeoriginal ()
        {
            // /image/(*)!sizeoriginal 
            return await image____sizeoriginal(string.Empty); 
        }

        public async Task<VideoSize110Entity> Fixup_video____size110 ()
        {
            // /video/(*)!size110 
            return await video____size110(string.Empty); 
        }

        public async Task<VideoSize1280Entity> Fixup_video____size1280 ()
        {
            // /video/(*)!size1280 
            return await video____size1280(string.Empty); 
        }

        public async Task<VideoSize1920Entity> Fixup_video____size1920 ()
        {
            // /video/(*)!size1920 
            return await video____size1920(string.Empty); 
        }

        public async Task<VideoSize200Entity> Fixup_video____size200 ()
        {
            // /video/(*)!size200 
            return await video____size200(string.Empty); 
        }

        public async Task<VideoSize320Entity> Fixup_video____size320 ()
        {
            // /video/(*)!size320 
            return await video____size320(string.Empty); 
        }

        public async Task<VideoSize640Entity> Fixup_video____size640 ()
        {
            // /video/(*)!size640 
            return await video____size640(string.Empty); 
        }

        public async Task<VideoSize960Entity> Fixup_video____size960 ()
        {
            // /video/(*)!size960 
            return await video____size960(string.Empty); 
        }

        public async Task<VideoSMILEntity> Fixup_video____smil ()
        {
            // /video/(*)!smil 
            return await video____smil(string.Empty); 
        }
    }
}
