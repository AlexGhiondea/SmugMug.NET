// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageEntity : SmugMugEntity
    {

        public async Task<AlbumEntity> Fixup_album___ ()
        {
            // /album/(*) 
            return await album___(string.Empty); 
        }

        public async Task<ColorImageEntity> Fixup_image____color ()
        {
            // /image/(*)!color 
            return await image____color(string.Empty); 
        }

        public async Task<CommentEntity[]> Fixup_image____comments ()
        {
            // /image/(*)!comments 
            return await image____comments(string.Empty); 
        }

        public async Task Fixup_image____crop ()
        {
            // /image/(*)!crop 
            await image____crop(string.Empty); 
        }

        public async Task<ImageDownloadEntity> Fixup_image____download ()
        {
            // /image/(*)!download 
            return await image____download(string.Empty); 
        }

        public async Task<ImageMetadataEntity> Fixup_image____metadata ()
        {
            // /image/(*)!metadata 
            return await image____metadata(string.Empty); 
        }

        public async Task<CatalogSkuPriceEntity[]> Fixup_image____prices ()
        {
            // /image/(*)!prices 
            return await image____prices(string.Empty); 
        }

        public async Task Fixup_image____rotate ()
        {
            // /image/(*)!rotate 
            await image____rotate(string.Empty); 
        }

        public async Task Fixup_image____watermark ()
        {
            // /image/(*)!watermark 
            await image____watermark(string.Empty); 
        }

        public async Task<LargestImageEntity> Fixup_image____largestimage ()
        {
            // /image/(*)!largestimage 
            return await image____largestimage(string.Empty); 
        }

        public async Task<ImageSizeDetailsEntity> Fixup_image____sizedetails ()
        {
            // /image/(*)!sizedetails 
            return await image____sizedetails(string.Empty); 
        }

        public async Task<ImageSizesEntity> Fixup_image____sizes ()
        {
            // /image/(*)!sizes 
            return await image____sizes(string.Empty); 
        }

        public async Task<LargestVideoEntity> Fixup_image____largestvideo ()
        {
            // /image/(*)!largestvideo 
            return await image____largestvideo(string.Empty); 
        }

        public async Task<UserEntity> Fixup_user___ ()
        {
            // /user/(*) 
            return await user___(string.Empty); 
        }

        public async Task<CSMILVideoEntity> Fixup_video____csmil ()
        {
            // /video/(*)!csmil 
            return await video____csmil(string.Empty); 
        }

        public async Task<EmbedVideoEntity> Fixup_video____embed ()
        {
            // /video/(*)!embed 
            return await video____embed(string.Empty); 
        }
    }
}
