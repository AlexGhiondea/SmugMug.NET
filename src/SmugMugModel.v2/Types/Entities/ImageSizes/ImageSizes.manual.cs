// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {

        public async Task<LargestImageEntity> GetLargestImageAsync()
        {
            // /image/(*)!largestimage 
            return await image____largestimage(ParentEntity.EntityId + "-0");
        }

        public async Task<LargestVideoEntity> GetLargestVideoAsync()
        {
            // /image/(*)!largestvideo 
            return await image____largestvideo(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeCustomEntity> GetImageSizeCustomAsync()
        {
            // /image/(*)!sizecustom 
            return await image____sizecustom(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeLargeEntity> GetImageSizeLargeAsync()
        {
            // /image/(*)!sizelarge 
            return await image____sizelarge(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeMediumEntity> GetImageSizeMediumAsync()
        {
            // /image/(*)!sizemedium 
            return await image____sizemedium(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeSmallEntity> GetImageSizeSmallAsync()
        {
            // /image/(*)!sizesmall 
            return await image____sizesmall(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeThumbEntity> GetImageSizeThumbAsync()
        {
            // /image/(*)!sizethumb 
            return await image____sizethumb(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeTinyEntity> GetImageSizeTinyAsync()
        {
            // /image/(*)!sizetiny 
            return await image____sizetiny(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeX2LargeEntity> GetImageSizeX2lLargeAsync()
        {
            // /image/(*)!sizex2large 
            return await image____sizex2large(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeX3LargeEntity> GetImageSizeX3LargeAsync()
        {
            // /image/(*)!sizex3large 
            return await image____sizex3large(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeXLargeEntity> GetImageSizeXLargeAsync()
        {
            // /image/(*)!sizexlarge 
            return await image____sizexlarge(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeOriginalEntity> GetImageSizeOriginalAsync()
        {
            // /image/(*)!sizeoriginal 
            return await image____sizeoriginal(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize110Entity> GetVideoSize110Async()
        {
            // /video/(*)!size110 
            return await video____size110(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize1280Entity> GetVideoSize1280Async()
        {
            // /video/(*)!size1280 
            return await video____size1280(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize1920Entity> GetVideoSize1920Async()
        {
            // /video/(*)!size1920 
            return await video____size1920(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize200Entity> GetVideoSize200Async()
        {
            // /video/(*)!size200 
            return await video____size200(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize320Entity> GetVideoSize320Async()
        {
            // /video/(*)!size320 
            return await video____size320(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize640Entity> GetVideoSize640Async()
        {
            // /video/(*)!size640 
            return await video____size640(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSize960Entity> GetVideoSize960Async()
        {
            // /video/(*)!size960 
            return await video____size960(ParentEntity.EntityId + "-0");
        }

        public async Task<VideoSMILEntity> GetVideoSMILAsync()
        {
            // /video/(*)!smil 
            return await video____smil(ParentEntity.EntityId + "-0");
        }
    }
}
