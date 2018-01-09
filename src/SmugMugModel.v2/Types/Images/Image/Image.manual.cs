// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;
using SmugMug.v2.Utility;
using System.Collections.Generic;

namespace SmugMug.v2.Types
{
    public partial class ImageEntity : SmugMugEntity
    {
        public override string PatchUri
        {
            get
            {
                return "/api/v2/image/" + ImageKey;
            }
        }

        public async Task<AlbumImageShareUrisEntity> GetShareUrisAsync()
        {
            // /album/(*)/image/(*)!shareuris 
            string requestUri = string.Format("{0}/album/{1}/image/{2}!shareuris", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId, ImageKey);

            return await RetrieveEntityAsync<AlbumImageShareUrisEntity>(requestUri);
        }

        public override string EntityId
        {
            get { return ImageKey; }
        }

        public async Task<AlbumEntity> GetAlbumAsync()
        {
            // TODO: Consider returning Parent here instead.
            // /album/(*) 
            //return await album___(Parent.EntityId);

            // /album/(*) 
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri);
        }

        public async Task ColorAsync(ColorEnum color)
        {
            string colorValue = color.GetEnumMemberValue();

            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Color", colorValue));
            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /image/(*)!crop 
            string requestUri = string.Format("{0}/image/{1}!color", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task<CommentEntity[]> GetCommentsAsync()
        {
            // /image/(*)!comments 
            //return await image____comments(ImageKey);

            // /image/(*)!comments 
            string requestUri = string.Format("{0}/image/{1}!comments", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityArrayAsync<CommentEntity>(requestUri);
        }

        public async Task CropAsync(long topLeftX, long topLeftY, long height, long width, bool thumbOnly)
        {
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("TopLeftX", topLeftX));
            postProperties.Add(new KeyValuePair<string, object>("TopLeftY", topLeftY));
            postProperties.Add(new KeyValuePair<string, object>("Height", height));
            postProperties.Add(new KeyValuePair<string, object>("Width", width));
            postProperties.Add(new KeyValuePair<string, object>("ThumbOnly", thumbOnly));
            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /image/(*)!crop 
            string requestUri = string.Format("{0}/image/{1}!crop", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task<ImageDownloadEntity> GetDownloadAsync()
        {
            // /image/(*)!download 
            //return await image____download(ImageKey);

            // /image/(*)!download 
            string requestUri = string.Format("{0}/image/{1}!download", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<ImageDownloadEntity>(requestUri);
        }

        public async Task<ImageMetadataEntity> GetMetadataAsync()
        {
            // /image/(*)!metadata 
            //return await image____metadata(ImageKey);

            // /image/(*)!metadata 
            string requestUri = string.Format("{0}/image/{1}!metadata", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<ImageMetadataEntity>(requestUri);
        }

        public async Task<CatalogSkuPriceEntity[]> GetPricesAsync()
        {
            // /image/(*)!prices 
            //return await image____prices(ImageKey);

            // /image/(*)!prices 
            string requestUri = string.Format("{0}/image/{1}!prices", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityArrayAsync<CatalogSkuPriceEntity>(requestUri);
        }

        public async Task RotateAsync(DegreesEnum degrees, FlipEnum flip)
        {
            string flipValue = flip.GetEnumMemberValue();
            string degreesValue = degrees.GetEnumMemberValue();

            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Degrees", degreesValue));
            postProperties.Add(new KeyValuePair<string, object>("Flip", flipValue));
            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /image/(*)!rotate 
            string requestUri = string.Format("{0}/image/{1}!rotate", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task ApplyWatermarkAsync(WatermarkEntity watermark)
        {
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Mode", "Add"));
            postProperties.Add(new KeyValuePair<string, object>("WatermarkUri", watermark.Uri));
            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /image/(*)!watermark 
            string requestUri = string.Format("{0}/image/{1}!watermark", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task RemoveWatermarkAsync()
        {
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Mode", "Remove"));
            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            // /image/(*)!watermark 
            string requestUri = string.Format("{0}/image/{1}!watermark", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task<LargestImageEntity> GetLargestImageAsync()
        {
            // /image/(*)!largestimage 
            //return await image____largestimage(ImageKey);

            // /image/(*)!largestimage 
            string requestUri = string.Format("{0}/image/{1}!largestimage", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<LargestImageEntity>(requestUri);
        }

        public async Task<ImageSizeDetailsEntity> GetSizeDetails()
        {
            // /image/(*)!sizedetails 
            //return await image____sizedetails(ImageKey);

            // /image/(*)!sizedetails 
            string requestUri = string.Format("{0}/image/{1}!sizedetails", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<ImageSizeDetailsEntity>(requestUri);
        }

        public async Task<ImageSizesEntity> GetImageSizesAsync()
        {
            // NOTE: We need to append -0 to the image key otherwise we will not get the right value 
            // /image/(*)!sizes 
            //return await image____sizes();

            // /image/(*)!sizes 
            string requestUri = string.Format("{0}/image/{1}!sizes", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey + "-0");

            return await RetrieveEntityAsync<ImageSizesEntity>(requestUri);
        }

        public async Task<LargestVideoEntity> GetLargestVideoAsync()
        {
            // /image/(*)!largestvideo 
            //return await image____largestvideo(ImageKey);

            // /image/(*)!largestvideo 
            string requestUri = string.Format("{0}/image/{1}!largestvideo", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<LargestVideoEntity>(requestUri);
        }

        public async Task<UserEntity> Considered_Fixup_user___()
        {
            // /user/(*) 
            //return await user___(string.Empty);

            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }

        public async Task<CSMILVideoEntity> GetVideoCSMILAsync()
        {
            // /video/(*)!csmil 
            //return await video____csmil();

            // /video/(*)!csmil 
            string requestUri = string.Format("{0}/video/{1}!csmil", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<CSMILVideoEntity>(requestUri);
        }

        public async Task<EmbedVideoEntity> GetEmbedVideoAsync()
        {
            // /video/(*)!embed 
            //return await video____embed(ImageKey);

            // /video/(*)!embed 
            string requestUri = string.Format("{0}/video/{1}!embed", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey);

            return await RetrieveEntityAsync<EmbedVideoEntity>(requestUri);
        }
    }
}
