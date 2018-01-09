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
            //return await image____largestimage(ParentEntity.EntityId + "-0");

            // /image/(*)!largestimage 
            string requestUri = string.Format("{0}/image/{1}!largestimage", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri);
        }

        public async Task<LargestVideoEntity> GetLargestVideoAsync()
        {
            // /image/(*)!largestvideo 
            //return await image____largestvideo(ParentEntity.EntityId + "-0");

            // /image/(*)!largestvideo 
            string requestUri = string.Format("{0}/image/{1}!largestvideo", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri);
        }

        public async Task<ImageSizeCustomEntity> GetImageSizeCustomAsync()
        {
            //// /image/(*)!sizecustom 
            //return await image____sizecustom(ParentEntity.EntityId + "-0");

            // /image/(*)!sizecustom 
            string requestUri = string.Format("{0}/image/{1}!sizecustom", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeCustomEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeLargeAsync()
        {
            // /image/(*)!sizelarge 
            //return await image____sizelarge(ParentEntity.EntityId + "-0");

            // /image/(*)!sizelarge 
            string requestUri = string.Format("{0}/image/{1}!sizelarge", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeMediumAsync()
        {
            // /image/(*)!sizemedium 
            //return await image____sizemedium(ParentEntity.EntityId + "-0");

            string requestUri = string.Format("{0}/image/{1}!sizemedium", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeSmallAsync()
        {
            // /image/(*)!sizesmall 
            //return await image____sizesmall(ParentEntity.EntityId + "-0");

            // /image/(*)!sizesmall 
            string requestUri = string.Format("{0}/image/{1}!sizesmall", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeThumbAsync()
        {
            // /image/(*)!sizethumb 
            //return await image____sizethumb(ParentEntity.EntityId + "-0");

            // /image/(*)!sizethumb 
            string requestUri = string.Format("{0}/image/{1}!sizethumb", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeTinyAsync()
        {
            // /image/(*)!sizetiny 
            //return await image____sizetiny(ParentEntity.EntityId + "-0");

            // /image/(*)!sizetiny 
            string requestUri = string.Format("{0}/image/{1}!sizetiny", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeX2lLargeAsync()
        {
            // /image/(*)!sizex2large 
            //return await image____sizex2large(ParentEntity.EntityId + "-0");

            // /image/(*)!sizex2large 
            string requestUri = string.Format("{0}/image/{1}!sizex2large", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeX3LargeAsync()
        {
            // /image/(*)!sizex3large 
            //return await image____sizex3large(ParentEntity.EntityId + "-0");

            // /image/(*)!sizex3large 
            string requestUri = string.Format("{0}/image/{1}!sizex3large", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeXLargeAsync()
        {
            // /image/(*)!sizexlarge 
            //return await image____sizexlarge(ParentEntity.EntityId + "-0");

            // /image/(*)!sizexlarge 
            string requestUri = string.Format("{0}/image/{1}!sizexlarge", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetImageSizeOriginalAsync()
        {
            // /image/(*)!sizeoriginal 
            //return await image____sizeoriginal(ParentEntity.EntityId + "-0");

            // /image/(*)!sizeoriginal 
            string requestUri = string.Format("{0}/image/{1}!sizeoriginal", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize110Async()
        {
            // /video/(*)!size110 
            //return await video____size110(ParentEntity.EntityId + "-0");

            // /video/(*)!size110 
            string requestUri = string.Format("{0}/video/{1}!size110", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize1280Async()
        {
            // /video/(*)!size1280 
            //return await video____size1280(ParentEntity.EntityId + "-0");

            // /video/(*)!size1280 
            string requestUri = string.Format("{0}/video/{1}!size1280", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize1920Async()
        {
            // /video/(*)!size1920 
            //return await video____size1920(ParentEntity.EntityId + "-0");

            // /video/(*)!size1920 
            string requestUri = string.Format("{0}/video/{1}!size1920", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize200Async()
        {
            // /video/(*)!size200 
            //return await video____size200(ParentEntity.EntityId + "-0");

            // /video/(*)!size200 
            string requestUri = string.Format("{0}/video/{1}!size200", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize320Async()
        {
            // /video/(*)!size320 
            //return await video____size320(ParentEntity.EntityId + "-0");

            // /video/(*)!size320 
            string requestUri = string.Format("{0}/video/{1}!size320", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize640Async()
        {
            // /video/(*)!size640 
            //return await video____size640(ParentEntity.EntityId + "-0");

            // /video/(*)!size640 
            string requestUri = string.Format("{0}/video/{1}!size640", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSize960Async()
        {
            // /video/(*)!size960 
           // return await video____size960(ParentEntity.EntityId + "-0");

            // /video/(*)!size960 
            string requestUri = string.Format("{0}/video/{1}!size960", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }

        public async Task<ImageSizeEntity> GetVideoSMILAsync()
        {
            // /video/(*)!smil 
            //return await video____smil(ParentEntity.EntityId + "-0");

            // /video/(*)!smil 
            string requestUri = string.Format("{0}/video/{1}!smil", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId + "-0");

            return await RetrieveEntityAsync<ImageSizeEntity>(requestUri);
        }
    }
}
