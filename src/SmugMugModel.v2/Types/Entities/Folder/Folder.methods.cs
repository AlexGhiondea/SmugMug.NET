// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
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


        public List<string> GetPatchParameters()
        {
            return new List<string>(){ "Name","UrlName","AutoRename","SecurityType","SortMethod","SortDirection","Description","Keywords","Password","PasswordHint","Privacy","SmugSearchable","WorldSearchable","HighlightImageUri" };
        }

        public List<string> GetPostParameters()
        {
            return new List<string>(){ "Name","UrlName","AutoRename","SecurityType","SortMethod","SortDirection","Description","Keywords","Password","PasswordHint","Privacy","SmugSearchable","WorldSearchable","HighlightImageUri" };
        }


        public async Task<FolderEntity> folderid___ (string param1)
        {
            // /folder/id/(*) 
            string requestUri = string.Format("{0}/folder/id/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task folderuser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("{0}/folder/user/{1}!albumfromalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser____albumlist (string param1)
        {
            // /folder/user/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser____albums (string param1)
        {
            // /folder/user/(*)!albums 
            string requestUri = string.Format("{0}/folder/user/{1}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser____folderlist (string param1)
        {
            // /folder/user/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser____folders (string param1)
        {
            // /folder/user/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser____grants (string param1)
        {
            // /folder/user/(*)!grants 
            string requestUri = string.Format("{0}/folder/user/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser____highlightimage (string param1)
        {
            // /folder/user/(*)!highlightimage 
            string requestUri = string.Format("{0}/folder/user/{1}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser____movealbums (string param1)
        {
            // /folder/user/(*)!movealbums 
            string requestUri = string.Format("{0}/folder/user/{1}!movealbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____movefolders (string param1)
        {
            // /folder/user/(*)!movefolders 
            string requestUri = string.Format("{0}/folder/user/{1}!movefolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____movepages (string param1)
        {
            // /folder/user/(*)!movepages 
            string requestUri = string.Format("{0}/folder/user/{1}!movepages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser____pages (string param1)
        {
            // /folder/user/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser____parents (string param1)
        {
            // /folder/user/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser____size (string param1)
        {
            // /folder/user/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser____sortalbums (string param1)
        {
            // /folder/user/(*)!sortalbums 
            string requestUri = string.Format("{0}/folder/user/{1}!sortalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____sortfolders (string param1)
        {
            // /folder/user/(*)!sortfolders 
            string requestUri = string.Format("{0}/folder/user/{1}!sortfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser____sortpages (string param1)
        {
            // /folder/user/(*)!sortpages 
            string requestUri = string.Format("{0}/folder/user/{1}!sortpages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!albumfromalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser_______albumlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser_______albums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albums 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser_______folderlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser_______folders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser_______grants (string param1, string param2)
        {
            // /folder/user/(*)/(*)!grants 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser_______highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/(*)!highlightimage 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser_______movealbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movealbums 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!movealbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______movefolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movefolders 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!movefolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______movepages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movepages 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!movepages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser_______pages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser_______parent (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parent 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!parent", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser_______size (string param1, string param2)
        {
            // /folder/user/(*)/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser_______sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortalbums 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!sortalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortfolders 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!sortfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser_______sortpages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortpages 
            string requestUri = string.Format("{0}/folder/user/{1}/{2}!sortpages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumfromalbumtemplate 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!albumfromalbumtemplate", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___albumName____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___albumName____albums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albums 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___albumName____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___albumName____folders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<GrantEntity[]> folderuser___albumName____grants (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!grants 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___albumName____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!highlightimage 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task folderuser___albumName____movealbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movealbums 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!movealbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____movefolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movefolders 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!movefolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____movepages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movepages 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!movepages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___albumName____pages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___albumName____parent (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parent 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!parent", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___albumName____size (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task folderuser___albumName____sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortalbums 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!sortalbums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortfolders 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!sortfolders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task folderuser___albumName____sortpages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortpages 
            string requestUri = string.Format("{0}/folder/user/{1}/albumName/{2}!sortpages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            await GetRequestAsync(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___Family____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___Family____albums (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albums 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___Family____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___Family____folders (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___Family____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___Family____pages (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___Family____parent (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parent 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!parent", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___Family____size (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}/Family/{2}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task<AlbumListEntity> folderuser___SmugMug____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!albumlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<AlbumListEntity>(requestUri); 
        }

        public async Task<AlbumEntity[]> folderuser___SmugMug____albums (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!albums", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri); 
        }

        public async Task<FolderListEntity> folderuser___SmugMug____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!folderlist", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderListEntity>(requestUri); 
        }

        public async Task<FolderEntity[]> folderuser___SmugMug____folders (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!folders", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<FolderEntity>(requestUri); 
        }

        public async Task<ImageEntity> folderuser___SmugMug____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!highlightimage", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<PageEntity[]> folderuser___SmugMug____pages (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!pages", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityArrayAsync<PageEntity>(requestUri); 
        }

        public async Task<FolderEntity> folderuser___SmugMug____parent (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!parent", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<FolderEntity>(requestUri); 
        }

        public async Task<SizeEntity> folderuser___SmugMug____size (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            string requestUri = string.Format("{0}/folder/user/{1}/SmugMug/{2}!size", SmugMug.v2.Constants.Addresses.SmugMugApi, param1,param2);

            return await RetrieveEntityAsync<SizeEntity>(requestUri); 
        }

        public async Task<ImageEntity> highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("{0}/highlight/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<ImageEntity>(requestUri); 
        }

        public async Task<NodeEntity> node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("{0}/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<NodeEntity>(requestUri); 
        }

        public async Task<UserEntity> user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("{0}/user/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityAsync<UserEntity>(requestUri); 
        }
    }
}
