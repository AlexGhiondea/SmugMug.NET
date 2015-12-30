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

        public async Task<ImageSizeEntity> GetImageSizeLargeAsync()
        {
            // /image/(*)!sizelarge 
            return await image____sizelarge(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeMediumAsync()
        {
            // /image/(*)!sizemedium 
            return await image____sizemedium(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeSmallAsync()
        {
            // /image/(*)!sizesmall 
            return await image____sizesmall(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeThumbAsync()
        {
            // /image/(*)!sizethumb 
            return await image____sizethumb(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeTinyAsync()
        {
            // /image/(*)!sizetiny 
            return await image____sizetiny(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeX2lLargeAsync()
        {
            // /image/(*)!sizex2large 
            return await image____sizex2large(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeX3LargeAsync()
        {
            // /image/(*)!sizex3large 
            return await image____sizex3large(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeXLargeAsync()
        {
            // /image/(*)!sizexlarge 
            return await image____sizexlarge(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetImageSizeOriginalAsync()
        {
            // /image/(*)!sizeoriginal 
            return await image____sizeoriginal(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize110Async()
        {
            // /video/(*)!size110 
            return await video____size110(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize1280Async()
        {
            // /video/(*)!size1280 
            return await video____size1280(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize1920Async()
        {
            // /video/(*)!size1920 
            return await video____size1920(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize200Async()
        {
            // /video/(*)!size200 
            return await video____size200(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize320Async()
        {
            // /video/(*)!size320 
            return await video____size320(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize640Async()
        {
            // /video/(*)!size640 
            return await video____size640(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSize960Async()
        {
            // /video/(*)!size960 
            return await video____size960(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeEntity> GetVideoSMILAsync()
        {
            // /video/(*)!smil 
            return await video____smil(ParentEntity.EntityId + "-0");
        }
    }
}
