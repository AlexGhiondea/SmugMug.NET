// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderEntity : SmugMugEntity
    {
        [Obsolete]
        public async Task<FolderEntity> Fixup_folderid___()
        {
            // /folder/id/(*) 
            return await folderid___(NodeId);
        }

        public async Task RequiresPost_Fixup_folderuser____albumfromalbumtemplate()
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            await folderuser____albumfromalbumtemplate(string.Empty);
        }

        [Obsolete]
        public async Task<AlbumListEntity[]> GetAlbumListAsync()
        {
            // I can use urlpath to get the parent.

            // /folder/user/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);

            return await RetrieveEntityArrayAsync<AlbumListEntity>(requestUri);
        }

        [Obsolete]
        public async Task<FolderListEntity[]> GetFolderListAsync()
        {
            // /folder/user/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId);

            return await RetrieveEntityArrayAsync<FolderListEntity>(requestUri);
        }

        [Obsolete]
        public async Task<FolderEntity[]> GetFoldersAsync()
        {
            // /folder/user/(*)!folders 
            return await folderuser____folders(ParentEntity.EntityId);
        }

        [Obsolete]
        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /folder/user/(*)!grants 
            return await folderuser____grants(ParentEntity.EntityId);
        }

        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movealbums()
        {
            // /folder/user/(*)!movealbums 
            await folderuser____movealbums(string.Empty);
        }
        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movefolders()
        {
            // /folder/user/(*)!movefolders 
            await folderuser____movefolders(string.Empty);
        }
        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movepages()
        {
            // /folder/user/(*)!movepages 
            await folderuser____movepages(string.Empty);
        }

        [Obsolete]
        public async Task<PageEntity[]> GetPagesAsync()
        {
            // /folder/user/(*)!pages 
            return await folderuser____pages(ParentEntity.EntityId);
        }

        [Obsolete]
        public async Task<FolderEntity[]> GetParentsAsync()
        {
            // /folder/user/(*)!parents 
            return await folderuser____parents(ParentEntity.EntityId);
        }

        public async Task<SizeEntity> GetSizeAsync()
        {
            // /folder/user/(*)!size 
            return await folderuser____size(ParentEntity.EntityId);
        }

        public async Task RequiresPost_Fixup_folderuser____sortalbums()
        {
            // /folder/user/(*)!sortalbums 
            await folderuser____sortalbums(string.Empty);
        }

        public async Task RequiresPost_Fixup_folderuser____sortfolders()
        {
            // /folder/user/(*)!sortfolders 
            await folderuser____sortfolders(string.Empty);
        }

        public async Task RequiresPost_Fixup_folderuser____sortpages()
        {
            // /folder/user/(*)!sortpages 
            await folderuser____sortpages(string.Empty);
        }

        public async Task RequiresPost_Fixup_folderuser_______albumfromalbumtemplate()
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            await folderuser_______albumfromalbumtemplate(string.Empty, string.Empty);
        }

        public async Task<FolderEntity> GetParentAsync()
        {
            // /folder/user/(*)/(*)!parent 
            string requestUri = string.Format("{0}{1}!parent", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityAsync<FolderEntity>(requestUri);
        }

        public async Task<ImageEntity> GetHighlightImageAsync()
        {
            // /highlight/node/(*) 
            return await highlightnode___(NodeId);
        }

        public async Task<NodeEntity> GetNodeAsync()
        {
            // /node/(*) 
            return await node___(NodeId);
        }

        public async Task<UserEntity> GetUserAsync()
        {
            // /user/(*) 
            return await user___(ParentEntity.EntityId);
        }

        //[Obsolete]
        //public async Task<ImageEntity> GetHighlightImageAsync()
        //{
        //    // /folder/user/(*)!highlightimage 
        //    return await folderuser____highlightimage(ParentEntity.EntityId);
        //}
    }
}
