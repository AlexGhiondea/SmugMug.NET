// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SmugMug.v2.Utility;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class AlbumImageEntity : SmugMugEntity
    {
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

        public async Task<AlbumImageShareUrisEntity> GetShareUris()
        {
            // /album/(*)/image/(*)!shareuris 
            return await album___image____shareuris(ParentEntity.EntityId, ImageKey);
        }

        public async Task<ColorImageEntity> RequiresPost_ColorImageAsync(ColorEnum color)
        {
            //string colorValue = color == ColorEnum.BW ? "B/W" : color.ToString();
            string colorValue = color.GetEnumMemberValue();

            // /image/(*)!color?Color=<color>
            string requestUri = string.Format("{0}/image/{1}!color?Color={2}", SmugMug.v2.Constants.Addresses.SmugMugApi, ImageKey, colorValue);

            return await RetrieveEntityAsync<ColorImageEntity>(requestUri);
        }

        public async Task<CommentEntity[]> GetCommentsAsync()
        {
            // /image/(*)!comments 
            return await image____comments(ImageKey);
        }

        public async Task RequiresPost_Fixup_image____crop()
        {
            // /image/(*)!crop 
            await image____crop(string.Empty);
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

        public async Task RequiresPost_Fixup_image____rotate()
        {
            // /image/(*)!rotate 
            await image____rotate(string.Empty);
        }

        public async Task RequiresPost_Fixup_image____watermark()
        {
            // /image/(*)!watermark 
            await image____watermark(string.Empty);
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
