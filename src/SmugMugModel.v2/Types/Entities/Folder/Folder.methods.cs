// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
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


        public FolderEntity folderid___ (string param1)
        {
            // /folder/id/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/id/{0}", param1);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public void folderuser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            return; 
        }

        public AlbumListEntity folderuser____albumlist (string param1)
        {
            // /folder/user/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!albumlist{1}", param1);

            return RetrieveEntityAsync<AlbumListEntity>(requestUri).Result; 
        }

        public AlbumEntity[] folderuser____albums (string param1)
        {
            // /folder/user/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!albums{1}", param1);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderListEntity folderuser____folderlist (string param1)
        {
            // /folder/user/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!folderlist{1}", param1);

            return RetrieveEntityAsync<FolderListEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser____folders (string param1)
        {
            // /folder/user/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!folders{1}", param1);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public GrantEntity[] folderuser____grants (string param1)
        {
            // /folder/user/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!grants{1}", param1);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public ImageEntity folderuser____highlightimage (string param1)
        {
            // /folder/user/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!highlightimage{1}", param1);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public void folderuser____movealbums (string param1)
        {
            // /folder/user/(*)!movealbums 
            return; 
        }

        public void folderuser____movefolders (string param1)
        {
            // /folder/user/(*)!movefolders 
            return; 
        }

        public void folderuser____movepages (string param1)
        {
            // /folder/user/(*)!movepages 
            return; 
        }

        public PageEntity[] folderuser____pages (string param1)
        {
            // /folder/user/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!pages{1}", param1);

            return RetrieveEntityArrayAsync<PageEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser____parents (string param1)
        {
            // /folder/user/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!parents{1}", param1);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public SizeEntity folderuser____size (string param1)
        {
            // /folder/user/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}!size{1}", param1);

            return RetrieveEntityAsync<SizeEntity>(requestUri).Result; 
        }

        public void folderuser____sortalbums (string param1)
        {
            // /folder/user/(*)!sortalbums 
            return; 
        }

        public void folderuser____sortfolders (string param1)
        {
            // /folder/user/(*)!sortfolders 
            return; 
        }

        public void folderuser____sortpages (string param1)
        {
            // /folder/user/(*)!sortpages 
            return; 
        }

        public void folderuser_______albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            return; 
        }

        public AlbumListEntity folderuser_______albumlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!albumlist{2}", param1,param2);

            return RetrieveEntityAsync<AlbumListEntity>(requestUri).Result; 
        }

        public AlbumEntity[] folderuser_______albums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!albums{2}", param1,param2);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderListEntity folderuser_______folderlist (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!folderlist{2}", param1,param2);

            return RetrieveEntityAsync<FolderListEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser_______folders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!folders{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public GrantEntity[] folderuser_______grants (string param1, string param2)
        {
            // /folder/user/(*)/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!grants{2}", param1,param2);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public ImageEntity folderuser_______highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!highlightimage{2}", param1,param2);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public void folderuser_______movealbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movealbums 
            return; 
        }

        public void folderuser_______movefolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movefolders 
            return; 
        }

        public void folderuser_______movepages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!movepages 
            return; 
        }

        public PageEntity[] folderuser_______pages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!pages{2}", param1,param2);

            return RetrieveEntityArrayAsync<PageEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser_______parent (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parent{2}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser_______parents (string param1, string param2)
        {
            // /folder/user/(*)/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!parents{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public SizeEntity folderuser_______size (string param1, string param2)
        {
            // /folder/user/(*)/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/{1}!size{2}", param1,param2);

            return RetrieveEntityAsync<SizeEntity>(requestUri).Result; 
        }

        public void folderuser_______sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortalbums 
            return; 
        }

        public void folderuser_______sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortfolders 
            return; 
        }

        public void folderuser_______sortpages (string param1, string param2)
        {
            // /folder/user/(*)/(*)!sortpages 
            return; 
        }

        public void folderuser___albumName____albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumfromalbumtemplate 
            return; 
        }

        public AlbumListEntity folderuser___albumName____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!albumlist{2}", param1,param2);

            return RetrieveEntityAsync<AlbumListEntity>(requestUri).Result; 
        }

        public AlbumEntity[] folderuser___albumName____albums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!albums{2}", param1,param2);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderListEntity folderuser___albumName____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!folderlist{2}", param1,param2);

            return RetrieveEntityAsync<FolderListEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___albumName____folders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!folders{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public GrantEntity[] folderuser___albumName____grants (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!grants{2}", param1,param2);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public ImageEntity folderuser___albumName____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!highlightimage{2}", param1,param2);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public void folderuser___albumName____movealbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movealbums 
            return; 
        }

        public void folderuser___albumName____movefolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movefolders 
            return; 
        }

        public void folderuser___albumName____movepages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movepages 
            return; 
        }

        public PageEntity[] folderuser___albumName____pages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!pages{2}", param1,param2);

            return RetrieveEntityArrayAsync<PageEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___albumName____parent (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!parent{2}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public SizeEntity folderuser___albumName____size (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/albumName/{1}!size{2}", param1,param2);

            return RetrieveEntityAsync<SizeEntity>(requestUri).Result; 
        }

        public void folderuser___albumName____sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortalbums 
            return; 
        }

        public void folderuser___albumName____sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortfolders 
            return; 
        }

        public void folderuser___albumName____sortpages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortpages 
            return; 
        }

        public AlbumListEntity folderuser___Family____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!albumlist{2}", param1,param2);

            return RetrieveEntityAsync<AlbumListEntity>(requestUri).Result; 
        }

        public AlbumEntity[] folderuser___Family____albums (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!albums{2}", param1,param2);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderListEntity folderuser___Family____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!folderlist{2}", param1,param2);

            return RetrieveEntityAsync<FolderListEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___Family____folders (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!folders{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public ImageEntity folderuser___Family____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!highlightimage{2}", param1,param2);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public PageEntity[] folderuser___Family____pages (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!pages{2}", param1,param2);

            return RetrieveEntityArrayAsync<PageEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___Family____parent (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!parent{2}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public SizeEntity folderuser___Family____size (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/Family/{1}!size{2}", param1,param2);

            return RetrieveEntityAsync<SizeEntity>(requestUri).Result; 
        }

        public AlbumListEntity folderuser___SmugMug____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!albumlist{2}", param1,param2);

            return RetrieveEntityAsync<AlbumListEntity>(requestUri).Result; 
        }

        public AlbumEntity[] folderuser___SmugMug____albums (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!albums{2}", param1,param2);

            return RetrieveEntityArrayAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderListEntity folderuser___SmugMug____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!folderlist{2}", param1,param2);

            return RetrieveEntityAsync<FolderListEntity>(requestUri).Result; 
        }

        public FolderEntity[] folderuser___SmugMug____folders (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!folders{2}", param1,param2);

            return RetrieveEntityArrayAsync<FolderEntity>(requestUri).Result; 
        }

        public ImageEntity folderuser___SmugMug____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!highlightimage{2}", param1,param2);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public PageEntity[] folderuser___SmugMug____pages (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!pages{2}", param1,param2);

            return RetrieveEntityArrayAsync<PageEntity>(requestUri).Result; 
        }

        public FolderEntity folderuser___SmugMug____parent (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!parent{2}", param1,param2);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public SizeEntity folderuser___SmugMug____size (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/user/{0}/SmugMug/{1}!size{2}", param1,param2);

            return RetrieveEntityAsync<SizeEntity>(requestUri).Result; 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/highlight/node/{0}", param1);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}", param1);

            return RetrieveEntityAsync<NodeEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }
    }
}
