// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class AlbumEntity : SmugMugEntity
    {

        public async Task<ApplyAlbumTemplateEntity> Fixup_album____applyalbumtemplate ()
        {
            // /album/(*)!applyalbumtemplate 
            return await album____applyalbumtemplate(string.Empty); 
        }

        public async Task Fixup_album____collectimages ()
        {
            // /album/(*)!collectimages 
            await album____collectimages(string.Empty); 
        }

        public async Task<CommentEntity[]> Fixup_album____comments ()
        {
            // /album/(*)!comments 
            return await album____comments(string.Empty); 
        }

        public async Task Fixup_album____deleteimages ()
        {
            // /album/(*)!deleteimages 
            await album____deleteimages(string.Empty); 
        }

        public async Task<DownloadEntity[]> Fixup_album____download ()
        {
            // /album/(*)!download 
            return await album____download(string.Empty); 
        }

        public async Task<AlbumImageEntity[]> Fixup_album____geomedia ()
        {
            // /album/(*)!geomedia 
            return await album____geomedia(string.Empty); 
        }

        public async Task<GrantEntity[]> Fixup_album____grants ()
        {
            // /album/(*)!grants 
            return await album____grants(string.Empty); 
        }

        public async Task<AlbumImageEntity> Fixup_album____highlightimage ()
        {
            // /album/(*)!highlightimage 
            return await album____highlightimage(string.Empty); 
        }

        public async Task<AlbumImageEntity[]> Fixup_album____images ()
        {
            // /album/(*)!images 
            return await album____images(string.Empty); 
        }

        public async Task Fixup_album____moveimages ()
        {
            // /album/(*)!moveimages 
            await album____moveimages(string.Empty); 
        }

        public async Task<AlbumImageEntity[]> Fixup_album____popularmedia ()
        {
            // /album/(*)!popularmedia 
            return await album____popularmedia(string.Empty); 
        }

        public async Task<CatalogSkuPriceEntity[]> Fixup_album____prices ()
        {
            // /album/(*)!prices 
            return await album____prices(string.Empty); 
        }

        public async Task<AlbumShareUrisEntity> Fixup_album____shareuris ()
        {
            // /album/(*)!shareuris 
            return await album____shareuris(string.Empty); 
        }

        public async Task Fixup_album____uploadfromuri ()
        {
            // /album/(*)!uploadfromuri 
            await album____uploadfromuri(string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser______ ()
        {
            // /folder/user/(*)/(*) 
            return await folderuser______(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser_______parents ()
        {
            // /folder/user/(*)/(*)!parents 
            return await folderuser_______parents(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___albumName___ ()
        {
            // /folder/user/(*)/albumName/(*) 
            return await folderuser___albumName___(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___albumName____parents ()
        {
            // /folder/user/(*)/albumName/(*)!parents 
            return await folderuser___albumName____parents(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___Family___ ()
        {
            // /folder/user/(*)/Family/(*) 
            return await folderuser___Family___(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___Family____parents ()
        {
            // /folder/user/(*)/Family/(*)!parents 
            return await folderuser___Family____parents(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___SmugMug___ ()
        {
            // /folder/user/(*)/SmugMug/(*) 
            return await folderuser___SmugMug___(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___SmugMug____parents ()
        {
            // /folder/user/(*)/SmugMug/(*)!parents 
            return await folderuser___SmugMug____parents(string.Empty, string.Empty); 
        }

        public async Task<ImageEntity> Fixup_highlightnode___ ()
        {
            // /highlight/node/(*) 
            return await highlightnode___(string.Empty); 
        }

        public async Task<NodeEntity> Fixup_node___ ()
        {
            // /node/(*) 
            return await node___(string.Empty); 
        }

        public async Task<UserEntity> Fixup_user___ ()
        {
            // /user/(*) 
            return await user___(string.Empty); 
        }

        public async Task<WatermarkEntity> Fixup_watermark___ ()
        {
            // /watermark/(*) 
            return await watermark___(string.Empty); 
        }
    }
}
