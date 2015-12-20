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
            return default(FolderEntity); 
        }

        public void folderuser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/(*)!albumfromalbumtemplate 
             
        }

        public AlbumListEntity folderuser____albumlist (string param1)
        {
            // /folder/user/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public AlbumEntity[] folderuser____albums (string param1)
        {
            // /folder/user/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public FolderListEntity folderuser____folderlist (string param1)
        {
            // /folder/user/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public FolderEntity[] folderuser____folders (string param1)
        {
            // /folder/user/(*)!folders 
            return default(FolderEntity[]); 
        }

        public GrantEntity[] folderuser____grants (string param1)
        {
            // /folder/user/(*)!grants 
            return default(GrantEntity[]); 
        }

        public ImageEntity folderuser____highlightimage (string param1)
        {
            // /folder/user/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public void folderuser____movealbums (string param1)
        {
            // /folder/user/(*)!movealbums 
             
        }

        public void folderuser____movefolders (string param1)
        {
            // /folder/user/(*)!movefolders 
             
        }

        public void folderuser____movepages (string param1)
        {
            // /folder/user/(*)!movepages 
             
        }

        public PageEntity[] folderuser____pages (string param1)
        {
            // /folder/user/(*)!pages 
            return default(PageEntity[]); 
        }

        public FolderEntity[] folderuser____parents (string param1)
        {
            // /folder/user/(*)!parents 
            return default(FolderEntity[]); 
        }

        public SizeEntity folderuser____size (string param1)
        {
            // /folder/user/(*)!size 
            return default(SizeEntity); 
        }

        public void folderuser____sortalbums (string param1)
        {
            // /folder/user/(*)!sortalbums 
             
        }

        public void folderuser____sortfolders (string param1)
        {
            // /folder/user/(*)!sortfolders 
             
        }

        public void folderuser____sortpages (string param1)
        {
            // /folder/user/(*)!sortpages 
             
        }

        public void folderusersmugmuguser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/smugmuguser/(*)!albumfromalbumtemplate 
             
        }

        public AlbumListEntity folderusersmugmuguser____albumlist (string param1)
        {
            // /folder/user/smugmuguser/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public AlbumEntity[] folderusersmugmuguser____albums (string param1)
        {
            // /folder/user/smugmuguser/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public FolderListEntity folderusersmugmuguser____folderlist (string param1)
        {
            // /folder/user/smugmuguser/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public FolderEntity[] folderusersmugmuguser____folders (string param1)
        {
            // /folder/user/smugmuguser/(*)!folders 
            return default(FolderEntity[]); 
        }

        public GrantEntity[] folderusersmugmuguser____grants (string param1)
        {
            // /folder/user/smugmuguser/(*)!grants 
            return default(GrantEntity[]); 
        }

        public ImageEntity folderusersmugmuguser____highlightimage (string param1)
        {
            // /folder/user/smugmuguser/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public void folderusersmugmuguser____movealbums (string param1)
        {
            // /folder/user/smugmuguser/(*)!movealbums 
             
        }

        public void folderusersmugmuguser____movefolders (string param1)
        {
            // /folder/user/smugmuguser/(*)!movefolders 
             
        }

        public void folderusersmugmuguser____movepages (string param1)
        {
            // /folder/user/smugmuguser/(*)!movepages 
             
        }

        public PageEntity[] folderusersmugmuguser____pages (string param1)
        {
            // /folder/user/smugmuguser/(*)!pages 
            return default(PageEntity[]); 
        }

        public FolderEntity folderusersmugmuguser____parent (string param1)
        {
            // /folder/user/smugmuguser/(*)!parent 
            return default(FolderEntity); 
        }

        public FolderEntity[] folderusersmugmuguser____parents (string param1)
        {
            // /folder/user/smugmuguser/(*)!parents 
            return default(FolderEntity[]); 
        }

        public SizeEntity folderusersmugmuguser____size (string param1)
        {
            // /folder/user/smugmuguser/(*)!size 
            return default(SizeEntity); 
        }

        public void folderusersmugmuguser____sortalbums (string param1)
        {
            // /folder/user/smugmuguser/(*)!sortalbums 
             
        }

        public void folderusersmugmuguser____sortfolders (string param1)
        {
            // /folder/user/smugmuguser/(*)!sortfolders 
             
        }

        public void folderusersmugmuguser____sortpages (string param1)
        {
            // /folder/user/smugmuguser/(*)!sortpages 
             
        }

        public void folderuser___albumName____albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumfromalbumtemplate 
             
        }

        public AlbumListEntity folderuser___albumName____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public AlbumEntity[] folderuser___albumName____albums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public FolderListEntity folderuser___albumName____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public FolderEntity[] folderuser___albumName____folders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!folders 
            return default(FolderEntity[]); 
        }

        public GrantEntity[] folderuser___albumName____grants (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!grants 
            return default(GrantEntity[]); 
        }

        public ImageEntity folderuser___albumName____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public void folderuser___albumName____movealbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movealbums 
             
        }

        public void folderuser___albumName____movefolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movefolders 
             
        }

        public void folderuser___albumName____movepages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!movepages 
             
        }

        public PageEntity[] folderuser___albumName____pages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!pages 
            return default(PageEntity[]); 
        }

        public FolderEntity folderuser___albumName____parent (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!parent 
            return default(FolderEntity); 
        }

        public SizeEntity folderuser___albumName____size (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!size 
            return default(SizeEntity); 
        }

        public void folderuser___albumName____sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortalbums 
             
        }

        public void folderuser___albumName____sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortfolders 
             
        }

        public void folderuser___albumName____sortpages (string param1, string param2)
        {
            // /folder/user/(*)/albumName/(*)!sortpages 
             
        }

        public AlbumListEntity folderuser___Family____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public AlbumEntity[] folderuser___Family____albums (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public FolderListEntity folderuser___Family____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public FolderEntity[] folderuser___Family____folders (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folders 
            return default(FolderEntity[]); 
        }

        public ImageEntity folderuser___Family____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public PageEntity[] folderuser___Family____pages (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!pages 
            return default(PageEntity[]); 
        }

        public FolderEntity folderuser___Family____parent (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parent 
            return default(FolderEntity); 
        }

        public SizeEntity folderuser___Family____size (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!size 
            return default(SizeEntity); 
        }

        public AlbumListEntity folderuser___SmugMug____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public AlbumEntity[] folderuser___SmugMug____albums (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public FolderListEntity folderuser___SmugMug____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public FolderEntity[] folderuser___SmugMug____folders (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            return default(FolderEntity[]); 
        }

        public ImageEntity folderuser___SmugMug____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public PageEntity[] folderuser___SmugMug____pages (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            return default(PageEntity[]); 
        }

        public FolderEntity folderuser___SmugMug____parent (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            return default(FolderEntity); 
        }

        public SizeEntity folderuser___SmugMug____size (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            return default(SizeEntity); 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public NodeEntity node___ (string param1)
        {
            // /node/(*) 
            return default(NodeEntity); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }
    }
}
