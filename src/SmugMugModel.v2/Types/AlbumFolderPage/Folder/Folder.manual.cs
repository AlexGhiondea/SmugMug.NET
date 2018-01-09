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
            // /folder/id/(*) 
            string requestUri = string.Format("{0}/folder/id/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);
            return await RetrieveEntityAsync<FolderEntity>(requestUri);
        }

        public async Task RequiresPost_Fixup_folderuser____albumfromalbumtemplate()
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            // /folder/user/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("{0}/folder/user/{1}!albumfromalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }

        [Obsolete]
        public async Task<AlbumListEntity[]> GetAlbumListAsync()
        {
            // I can use urlpath to get the parent.

            // /folder/user/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);

            return await RetrieveEntityArrayAsync<AlbumListEntity>(requestUri);
        }

        [Obsolete]
        public async Task<FolderListEntity[]> GetFolderListAsync()
        {
            // /folder/user/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);

            return await RetrieveEntityArrayAsync<FolderListEntity>(requestUri);
        }

        [Obsolete]
        public async Task<FolderEntity[]> GetFoldersAsync()
        {
            // /folder/user/(*)!folders 
            // /folder/user/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri);
        }

        [Obsolete]
        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /folder/user/(*)!grants 
            // /folder/user/(*)!grants 
            string requestUri = string.Format("{0}/folder/user/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri);
        }

        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movealbums()
        {
            // /folder/user/(*)!movealbums 
            // /folder/user/(*)!movealbums 
            string requestUri = string.Format("{0}/folder/user/{1}!movealbums", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }
        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movefolders()
        {
            // /folder/user/(*)!movefolders 
            // /folder/user/(*)!movefolders 
            string requestUri = string.Format("{0}/folder/user/{1}!movefolders", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }
        [Obsolete]
        public async Task RequiresPost_Fixup_folderuser____movepages()
        {
            // /folder/user/(*)!movepages 
            // /folder/user/(*)!movepages 
            string requestUri = string.Format("{0}/folder/user/{1}!movepages", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }

        [Obsolete]
        public async Task<PageEntity[]> GetPagesAsync()
        {
            // /folder/user/(*)!pages 
            // /folder/user/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityArrayAsync<PageEntity>(requestUri);
        }

        [Obsolete]
        public async Task<FolderEntity[]> GetParentsAsync()
        {
            // /folder/user/(*)!parents 
            // /folder/user/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri);
        }

        public async Task<SizeEntity> GetSizeAsync()
        {
            // /folder/user/(*)!size 
            // /folder/user/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityAsync<SizeEntity>(requestUri);
        }

        public async Task RequiresPost_Fixup_folderuser____sortalbums()
        {
            // /folder/user/(*)!sortalbums 
            // /folder/user/(*)!sortalbums 
            string requestUri = string.Format("{0}/folder/user/{1}!sortalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }

        public async Task RequiresPost_Fixup_folderuser____sortfolders()
        {
            // /folder/user/(*)!sortfolders 
            // /folder/user/(*)!sortfolders 
            string requestUri = string.Format("{0}/folder/user/{1}!sortfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }

        public async Task RequiresPost_Fixup_folderuser____sortpages()
        {
            // /folder/user/(*)!sortpages 
            // /folder/user/(*)!sortpages 
            string requestUri = string.Format("{0}/folder/user/{1}!sortpages", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            await GetRequestAsync(requestUri);
        }

        public async Task RequiresPost_Fixup_folderuser_______albumfromalbumtemplate()
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!albumfromalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty, string.Empty);

            await GetRequestAsync(requestUri);
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
            // /highlight/node/(*) 
            string requestUri = string.Format("{0}/highlight/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);
            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }

        public async Task<NodeEntity> GetNodeAsync()
        {
            // /node/(*) 
            // /node/(*) 
            string requestUri = string.Format("{0}/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);
            return await RetrieveEntityAsync<NodeEntity>(requestUri);
        }

        public async Task<UserEntity> GetUserAsync()
        {
            // /user/(*) 
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);
            return await RetrieveEntityAsync<UserEntity>(requestUri);
        }

        //[Obsolete]
        //public async Task<ImageEntity> GetHighlightImageAsync()
        //{
        //    // /folder/user/(*)!highlightimage 
        //    return await folderuser____highlightimage(Parent.EntityId);
        //}
    }
}
