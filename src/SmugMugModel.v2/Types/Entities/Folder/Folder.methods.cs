// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    [Obsolete]
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

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public ImageEntity folderuser____highlightimage (string param1)
        {
            // /folder/user/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderuser____folders (string param1)
        {
            // /folder/user/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderuser____folderlist (string param1)
        {
            // /folder/user/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public void folderuser____movefolders (string param1)
        {
            // /folder/user/(*)!movefolders 
             
        }

        public void folderuser____sortfolders (string param1)
        {
            // /folder/user/(*)!sortfolders 
             
        }

        public AlbumEntity[] folderuser____albums (string param1)
        {
            // /folder/user/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public void folderuser____albumfromalbumtemplate (string param1)
        {
            // /folder/user/(*)!albumfromalbumtemplate 
             
        }

        public void folderuser____sortalbums (string param1)
        {
            // /folder/user/(*)!sortalbums 
             
        }

        public void folderuser____movealbums (string param1)
        {
            // /folder/user/(*)!movealbums 
             
        }

        public AlbumListEntity folderuser____albumlist (string param1)
        {
            // /folder/user/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderuser____pages (string param1)
        {
            // /folder/user/(*)!pages 
            return default(PageEntity[]); 
        }

        public void folderuser____movepages (string param1)
        {
            // /folder/user/(*)!movepages 
             
        }

        public void folderuser____sortpages (string param1)
        {
            // /folder/user/(*)!sortpages 
             
        }

        public GrantEntity[] folderuser____grants (string param1)
        {
            // /folder/user/(*)!grants 
            return default(GrantEntity[]); 
        }

        public SizeEntity folderuser____size (string param1)
        {
            // /folder/user/(*)!size 
            return default(SizeEntity); 
        }

        public FolderEntity[] folderuser____parents (string param1)
        {
            // /folder/user/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuserghiondea____parent (string param1)
        {
            // /folder/user/ghiondea/(*)!parent 
            return default(FolderEntity); 
        }

        public ImageEntity folderuserghiondea____highlightimage (string param1)
        {
            // /folder/user/ghiondea/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderuserghiondea____folders (string param1)
        {
            // /folder/user/ghiondea/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderuserghiondea____folderlist (string param1)
        {
            // /folder/user/ghiondea/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public void folderuserghiondea____movefolders (string param1)
        {
            // /folder/user/ghiondea/(*)!movefolders 
             
        }

        public void folderuserghiondea____sortfolders (string param1)
        {
            // /folder/user/ghiondea/(*)!sortfolders 
             
        }

        public AlbumEntity[] folderuserghiondea____albums (string param1)
        {
            // /folder/user/ghiondea/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public void folderuserghiondea____albumfromalbumtemplate (string param1)
        {
            // /folder/user/ghiondea/(*)!albumfromalbumtemplate 
             
        }

        public void folderuserghiondea____sortalbums (string param1)
        {
            // /folder/user/ghiondea/(*)!sortalbums 
             
        }

        public void folderuserghiondea____movealbums (string param1)
        {
            // /folder/user/ghiondea/(*)!movealbums 
             
        }

        public AlbumListEntity folderuserghiondea____albumlist (string param1)
        {
            // /folder/user/ghiondea/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderuserghiondea____pages (string param1)
        {
            // /folder/user/ghiondea/(*)!pages 
            return default(PageEntity[]); 
        }

        public void folderuserghiondea____movepages (string param1)
        {
            // /folder/user/ghiondea/(*)!movepages 
             
        }

        public void folderuserghiondea____sortpages (string param1)
        {
            // /folder/user/ghiondea/(*)!sortpages 
             
        }

        public GrantEntity[] folderuserghiondea____grants (string param1)
        {
            // /folder/user/ghiondea/(*)!grants 
            return default(GrantEntity[]); 
        }

        public SizeEntity folderuserghiondea____size (string param1)
        {
            // /folder/user/ghiondea/(*)!size 
            return default(SizeEntity); 
        }

        public FolderEntity[] folderuserghiondea____parents (string param1)
        {
            // /folder/user/ghiondea/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuser___EthanAlbert____parent (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!parent 
            return default(FolderEntity); 
        }

        public ImageEntity folderuser___EthanAlbert____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderuser___EthanAlbert____folders (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderuser___EthanAlbert____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public void folderuser___EthanAlbert____movefolders (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!movefolders 
             
        }

        public void folderuser___EthanAlbert____sortfolders (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!sortfolders 
             
        }

        public AlbumEntity[] folderuser___EthanAlbert____albums (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public void folderuser___EthanAlbert____albumfromalbumtemplate (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!albumfromalbumtemplate 
             
        }

        public void folderuser___EthanAlbert____sortalbums (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!sortalbums 
             
        }

        public void folderuser___EthanAlbert____movealbums (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!movealbums 
             
        }

        public AlbumListEntity folderuser___EthanAlbert____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderuser___EthanAlbert____pages (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!pages 
            return default(PageEntity[]); 
        }

        public void folderuser___EthanAlbert____movepages (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!movepages 
             
        }

        public void folderuser___EthanAlbert____sortpages (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!sortpages 
             
        }

        public GrantEntity[] folderuser___EthanAlbert____grants (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!grants 
            return default(GrantEntity[]); 
        }

        public SizeEntity folderuser___EthanAlbert____size (string param1, string param2)
        {
            // /folder/user/(*)/Ethan-Albert/(*)!size 
            return default(SizeEntity); 
        }

        public FolderEntity[] folderusersmugmuguser____parents (string param1)
        {
            // /folder/user/smugmuguser/(*)!parents 
            return default(FolderEntity[]); 
        }

        public FolderEntity folderuser___Family____parent (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!parent 
            return default(FolderEntity); 
        }

        public ImageEntity folderuser___Family____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderuser___Family____folders (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderuser___Family____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public AlbumEntity[] folderuser___Family____albums (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public AlbumListEntity folderuser___Family____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderuser___Family____pages (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!pages 
            return default(PageEntity[]); 
        }

        public SizeEntity folderuser___Family____size (string param1, string param2)
        {
            // /folder/user/(*)/Family/(*)!size 
            return default(SizeEntity); 
        }

        public FolderEntity folderusersmugmuguser____parent (string param1)
        {
            // /folder/user/smugmuguser/(*)!parent 
            return default(FolderEntity); 
        }

        public ImageEntity folderusersmugmuguser____highlightimage (string param1)
        {
            // /folder/user/smugmuguser/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderusersmugmuguser____folders (string param1)
        {
            // /folder/user/smugmuguser/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderusersmugmuguser____folderlist (string param1)
        {
            // /folder/user/smugmuguser/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public AlbumEntity[] folderusersmugmuguser____albums (string param1)
        {
            // /folder/user/smugmuguser/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public AlbumListEntity folderusersmugmuguser____albumlist (string param1)
        {
            // /folder/user/smugmuguser/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderusersmugmuguser____pages (string param1)
        {
            // /folder/user/smugmuguser/(*)!pages 
            return default(PageEntity[]); 
        }

        public SizeEntity folderusersmugmuguser____size (string param1)
        {
            // /folder/user/smugmuguser/(*)!size 
            return default(SizeEntity); 
        }

        public FolderEntity folderuser___SmugMug____parent (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            return default(FolderEntity); 
        }

        public ImageEntity folderuser___SmugMug____highlightimage (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            return default(ImageEntity); 
        }

        public FolderEntity[] folderuser___SmugMug____folders (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            return default(FolderEntity[]); 
        }

        public FolderListEntity folderuser___SmugMug____folderlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            return default(FolderListEntity); 
        }

        public AlbumEntity[] folderuser___SmugMug____albums (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            return default(AlbumEntity[]); 
        }

        public AlbumListEntity folderuser___SmugMug____albumlist (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            return default(AlbumListEntity); 
        }

        public PageEntity[] folderuser___SmugMug____pages (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            return default(PageEntity[]); 
        }

        public SizeEntity folderuser___SmugMug____size (string param1, string param2)
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            return default(SizeEntity); 
        }
    }
}
