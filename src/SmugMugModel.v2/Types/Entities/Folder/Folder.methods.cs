// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderEntity : SmugMugEntity
    {
        public FolderEntity()
        {
            //Empty constructor to enable deserialization
        }

        public FolderEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<FolderEntity> folderid___ (string param1)
        {
            // /folder/id/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/id/{0}", param1);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task folderuser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!albumfromalbumtemplate", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser____albumlist (string param1)
        {
            // /folder/user/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!albumlist", param1);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser____albums (string param1)
        {
            // /folder/user/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!albums", param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser____folderlist (string param1)
        {
            // /folder/user/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!folderlist", param1);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser____folders (string param1)
        {
            // /folder/user/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!folders", param1);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser____grants (string param1)
        {
            // /folder/user/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!grants", param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser____highlightimage (string param1)
        {
            // /folder/user/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!highlightimage", param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser____movealbums (string param1)
        {
            // /folder/user/(*)!movealbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!movealbums", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____movefolders (string param1)
        {
            // /folder/user/(*)!movefolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!movefolders", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____movepages (string param1)
        {
            // /folder/user/(*)!movepages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!movepages", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser____pages (string param1)
        {
            // /folder/user/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!pages", param1);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser____parents (string param1)
        {
            // /folder/user/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!parents", param1);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser____size (string param1)
        {
            // /folder/user/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!size", param1);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser____sortalbums (string param1)
        {
            // /folder/user/(*)!sortalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!sortalbums", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____sortfolders (string param1)
        {
            // /folder/user/(*)!sortfolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!sortfolders", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____sortpages (string param1)
        {
            // /folder/user/(*)!sortpages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!sortpages", param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!albumfromalbumtemplate", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser_______albumlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!albumlist", param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser_______albums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!albums", param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser_______folderlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!folderlist", param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser_______folders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!folders", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser_______grants (string param1, string param2)
        {
            // /folder/user/(*)/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!grants", param1,param2);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser_______highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!highlightimage", param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser_______movealbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movealbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!movealbums", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______movefolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movefolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!movefolders", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______movepages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movepages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!movepages", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser_______pages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!pages", param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser_______parent (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parent", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parents", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser_______size (string param1, string param2)
        {
            // /folder/user/(*)/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!size", param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser_______sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!sortalbums", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortfolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!sortfolders", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______sortpages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortpages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!sortpages", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!albumfromalbumtemplate", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___albumName____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!albumlist", param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___albumName____albums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!albums", param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___albumName____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!folderlist", param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___albumName____folders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!folders", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser___albumName____grants (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!grants", param1,param2);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___albumName____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!highlightimage", param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser___albumName____movealbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movealbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!movealbums", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____movefolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movefolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!movefolders", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____movepages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movepages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!movepages", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___albumName____pages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!pages", param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___albumName____parent (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!parent", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___albumName____size (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!size", param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser___albumName____sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortalbums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!sortalbums", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortfolders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!sortfolders", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____sortpages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortpages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!sortpages", param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___Family____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!albumlist", param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___Family____albums (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!albums", param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___Family____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!folderlist", param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___Family____folders (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!folders", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___Family____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!highlightimage", param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___Family____pages (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!pages", param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___Family____parent (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!parent", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___Family____size (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!size", param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___SmugMug____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!albumlist", param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___SmugMug____albums (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!albums", param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___SmugMug____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!folderlist", param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___SmugMug____folders (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!folders", param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___SmugMug____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!highlightimage", param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___SmugMug____pages (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!pages", param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___SmugMug____parent (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!parent", param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___SmugMug____size (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!size", param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task<ImageEntity> highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/highlight/node/{0}", param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<NodeEntity> node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return await RetrieveEntityAsync<NodeEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
