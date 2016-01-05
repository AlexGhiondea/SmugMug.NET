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
            string requestUri = string.Format("{0}/album/{1}/image/{2}!shareuris", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId, ImageKey);

            return await RetrieveEntityAsync<AlbumImageShareUrisEntity>(requestUri);
        }

        public override string EntityId
        {
            get { return ImageKey; }
        }

        public async Task<AlbumEntity> GetAlbumAsync()
        {
            // TODO: Consider returning ParentEntity here instead.
            // /album/(*) 
            return await album___(ParentEntity.EntityId);
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
            return await image____comments(ImageKey);
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
            return await image____download(ImageKey);
        }

        public async Task<ImageMetadataEntity> GetMetadataAsync()
        {
            // /image/(*)!metadata 
            return await image____metadata(ImageKey);
        }

        public async Task<CatalogSkuPriceEntity[]> GetPricesAsync()
        {
            // /image/(*)!prices 
            return await image____prices(ImageKey);
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
            return await image____largestimage(ImageKey);
        }

        public async Task<ImageSizeDetailsEntity> GetSizeDetails()
        {
            // /image/(*)!sizedetails 
            return await image____sizedetails(ImageKey);
        }

        public async Task<ImageSizesEntity> GetImageSizesAsync()
        {
            // NOTE: We need to append -0 to the image key otherwise we will not get the right value 
            // /image/(*)!sizes 
            return await image____sizes(ImageKey + "-0");
        }

        public async Task<LargestVideoEntity> GetLargestVideoAsync()
        {
            // /image/(*)!largestvideo 
            return await image____largestvideo(ImageKey);
        }

        public async Task<UserEntity> Considered_Fixup_user___()
        {
            // /user/(*) 
            return await user___(string.Empty);
        }

        public async Task<CSMILVideoEntity> GetVideoCSMILAsync()
        {
            // /video/(*)!csmil 
            return await video____csmil(ImageKey);
        }

        public async Task<EmbedVideoEntity> GetEmbedVideoAsync()
        {
            // /video/(*)!embed 
            return await video____embed(ImageKey);
        }
    }
}
