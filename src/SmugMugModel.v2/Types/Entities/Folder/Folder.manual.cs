// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderEntity : SmugMugEntity
    {

        public async Task<FolderEntity> Fixup_folderid___ ()
        {
            // /folder/id/(*) 
            return await folderid___(string.Empty); 
        }

        public async Task Fixup_folderuser____albumfromalbumtemplate ()
        {
            // /folder/user/(*)!albumfromalbumtemplate 
            await folderuser____albumfromalbumtemplate(string.Empty); 
        }

        public async Task<AlbumListEntity> Fixup_folderuser____albumlist ()
        {
            // /folder/user/(*)!albumlist 
            return await folderuser____albumlist(string.Empty); 
        }

        public async Task<AlbumEntity[]> Fixup_folderuser____albums ()
        {
            // /folder/user/(*)!albums 
            return await folderuser____albums(string.Empty); 
        }

        public async Task<FolderListEntity> Fixup_folderuser____folderlist ()
        {
            // /folder/user/(*)!folderlist 
            return await folderuser____folderlist(string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser____folders ()
        {
            // /folder/user/(*)!folders 
            return await folderuser____folders(string.Empty); 
        }

        public async Task<GrantEntity[]> Fixup_folderuser____grants ()
        {
            // /folder/user/(*)!grants 
            return await folderuser____grants(string.Empty); 
        }

        public async Task<ImageEntity> Fixup_folderuser____highlightimage ()
        {
            // /folder/user/(*)!highlightimage 
            return await folderuser____highlightimage(string.Empty); 
        }

        public async Task Fixup_folderuser____movealbums ()
        {
            // /folder/user/(*)!movealbums 
            await folderuser____movealbums(string.Empty); 
        }

        public async Task Fixup_folderuser____movefolders ()
        {
            // /folder/user/(*)!movefolders 
            await folderuser____movefolders(string.Empty); 
        }

        public async Task Fixup_folderuser____movepages ()
        {
            // /folder/user/(*)!movepages 
            await folderuser____movepages(string.Empty); 
        }

        public async Task<PageEntity[]> Fixup_folderuser____pages ()
        {
            // /folder/user/(*)!pages 
            return await folderuser____pages(string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser____parents ()
        {
            // /folder/user/(*)!parents 
            return await folderuser____parents(string.Empty); 
        }

        public async Task<SizeEntity> Fixup_folderuser____size ()
        {
            // /folder/user/(*)!size 
            return await folderuser____size(string.Empty); 
        }

        public async Task Fixup_folderuser____sortalbums ()
        {
            // /folder/user/(*)!sortalbums 
            await folderuser____sortalbums(string.Empty); 
        }

        public async Task Fixup_folderuser____sortfolders ()
        {
            // /folder/user/(*)!sortfolders 
            await folderuser____sortfolders(string.Empty); 
        }

        public async Task Fixup_folderuser____sortpages ()
        {
            // /folder/user/(*)!sortpages 
            await folderuser____sortpages(string.Empty); 
        }

        public async Task Fixup_folderuser_______albumfromalbumtemplate ()
        {
            // /folder/user/(*)/(*)!albumfromalbumtemplate 
            await folderuser_______albumfromalbumtemplate(string.Empty, string.Empty); 
        }

        public async Task<AlbumListEntity> Fixup_folderuser_______albumlist ()
        {
            // /folder/user/(*)/(*)!albumlist 
            return await folderuser_______albumlist(string.Empty, string.Empty); 
        }

        public async Task<AlbumEntity[]> Fixup_folderuser_______albums ()
        {
            // /folder/user/(*)/(*)!albums 
            return await folderuser_______albums(string.Empty, string.Empty); 
        }

        public async Task<FolderListEntity> Fixup_folderuser_______folderlist ()
        {
            // /folder/user/(*)/(*)!folderlist 
            return await folderuser_______folderlist(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser_______folders ()
        {
            // /folder/user/(*)/(*)!folders 
            return await folderuser_______folders(string.Empty, string.Empty); 
        }

        public async Task<GrantEntity[]> Fixup_folderuser_______grants ()
        {
            // /folder/user/(*)/(*)!grants 
            return await folderuser_______grants(string.Empty, string.Empty); 
        }

        public async Task<ImageEntity> Fixup_folderuser_______highlightimage ()
        {
            // /folder/user/(*)/(*)!highlightimage 
            return await folderuser_______highlightimage(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______movealbums ()
        {
            // /folder/user/(*)/(*)!movealbums 
            await folderuser_______movealbums(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______movefolders ()
        {
            // /folder/user/(*)/(*)!movefolders 
            await folderuser_______movefolders(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______movepages ()
        {
            // /folder/user/(*)/(*)!movepages 
            await folderuser_______movepages(string.Empty, string.Empty); 
        }

        public async Task<PageEntity[]> Fixup_folderuser_______pages ()
        {
            // /folder/user/(*)/(*)!pages 
            return await folderuser_______pages(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser_______parent ()
        {
            // /folder/user/(*)/(*)!parent 
            return await folderuser_______parent(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser_______parents ()
        {
            // /folder/user/(*)/(*)!parents 
            return await folderuser_______parents(string.Empty, string.Empty); 
        }

        public async Task<SizeEntity> Fixup_folderuser_______size ()
        {
            // /folder/user/(*)/(*)!size 
            return await folderuser_______size(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______sortalbums ()
        {
            // /folder/user/(*)/(*)!sortalbums 
            await folderuser_______sortalbums(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______sortfolders ()
        {
            // /folder/user/(*)/(*)!sortfolders 
            await folderuser_______sortfolders(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser_______sortpages ()
        {
            // /folder/user/(*)/(*)!sortpages 
            await folderuser_______sortpages(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____albumfromalbumtemplate ()
        {
            // /folder/user/(*)/albumName/(*)!albumfromalbumtemplate 
            await folderuser___albumName____albumfromalbumtemplate(string.Empty, string.Empty); 
        }

        public async Task<AlbumListEntity> Fixup_folderuser___albumName____albumlist ()
        {
            // /folder/user/(*)/albumName/(*)!albumlist 
            return await folderuser___albumName____albumlist(string.Empty, string.Empty); 
        }

        public async Task<AlbumEntity[]> Fixup_folderuser___albumName____albums ()
        {
            // /folder/user/(*)/albumName/(*)!albums 
            return await folderuser___albumName____albums(string.Empty, string.Empty); 
        }

        public async Task<FolderListEntity> Fixup_folderuser___albumName____folderlist ()
        {
            // /folder/user/(*)/albumName/(*)!folderlist 
            return await folderuser___albumName____folderlist(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___albumName____folders ()
        {
            // /folder/user/(*)/albumName/(*)!folders 
            return await folderuser___albumName____folders(string.Empty, string.Empty); 
        }

        public async Task<GrantEntity[]> Fixup_folderuser___albumName____grants ()
        {
            // /folder/user/(*)/albumName/(*)!grants 
            return await folderuser___albumName____grants(string.Empty, string.Empty); 
        }

        public async Task<ImageEntity> Fixup_folderuser___albumName____highlightimage ()
        {
            // /folder/user/(*)/albumName/(*)!highlightimage 
            return await folderuser___albumName____highlightimage(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____movealbums ()
        {
            // /folder/user/(*)/albumName/(*)!movealbums 
            await folderuser___albumName____movealbums(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____movefolders ()
        {
            // /folder/user/(*)/albumName/(*)!movefolders 
            await folderuser___albumName____movefolders(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____movepages ()
        {
            // /folder/user/(*)/albumName/(*)!movepages 
            await folderuser___albumName____movepages(string.Empty, string.Empty); 
        }

        public async Task<PageEntity[]> Fixup_folderuser___albumName____pages ()
        {
            // /folder/user/(*)/albumName/(*)!pages 
            return await folderuser___albumName____pages(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___albumName____parent ()
        {
            // /folder/user/(*)/albumName/(*)!parent 
            return await folderuser___albumName____parent(string.Empty, string.Empty); 
        }

        public async Task<SizeEntity> Fixup_folderuser___albumName____size ()
        {
            // /folder/user/(*)/albumName/(*)!size 
            return await folderuser___albumName____size(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____sortalbums ()
        {
            // /folder/user/(*)/albumName/(*)!sortalbums 
            await folderuser___albumName____sortalbums(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____sortfolders ()
        {
            // /folder/user/(*)/albumName/(*)!sortfolders 
            await folderuser___albumName____sortfolders(string.Empty, string.Empty); 
        }

        public async Task Fixup_folderuser___albumName____sortpages ()
        {
            // /folder/user/(*)/albumName/(*)!sortpages 
            await folderuser___albumName____sortpages(string.Empty, string.Empty); 
        }

        public async Task<AlbumListEntity> Fixup_folderuser___Family____albumlist ()
        {
            // /folder/user/(*)/Family/(*)!albumlist 
            return await folderuser___Family____albumlist(string.Empty, string.Empty); 
        }

        public async Task<AlbumEntity[]> Fixup_folderuser___Family____albums ()
        {
            // /folder/user/(*)/Family/(*)!albums 
            return await folderuser___Family____albums(string.Empty, string.Empty); 
        }

        public async Task<FolderListEntity> Fixup_folderuser___Family____folderlist ()
        {
            // /folder/user/(*)/Family/(*)!folderlist 
            return await folderuser___Family____folderlist(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___Family____folders ()
        {
            // /folder/user/(*)/Family/(*)!folders 
            return await folderuser___Family____folders(string.Empty, string.Empty); 
        }

        public async Task<ImageEntity> Fixup_folderuser___Family____highlightimage ()
        {
            // /folder/user/(*)/Family/(*)!highlightimage 
            return await folderuser___Family____highlightimage(string.Empty, string.Empty); 
        }

        public async Task<PageEntity[]> Fixup_folderuser___Family____pages ()
        {
            // /folder/user/(*)/Family/(*)!pages 
            return await folderuser___Family____pages(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___Family____parent ()
        {
            // /folder/user/(*)/Family/(*)!parent 
            return await folderuser___Family____parent(string.Empty, string.Empty); 
        }

        public async Task<SizeEntity> Fixup_folderuser___Family____size ()
        {
            // /folder/user/(*)/Family/(*)!size 
            return await folderuser___Family____size(string.Empty, string.Empty); 
        }

        public async Task<AlbumListEntity> Fixup_folderuser___SmugMug____albumlist ()
        {
            // /folder/user/(*)/SmugMug/(*)!albumlist 
            return await folderuser___SmugMug____albumlist(string.Empty, string.Empty); 
        }

        public async Task<AlbumEntity[]> Fixup_folderuser___SmugMug____albums ()
        {
            // /folder/user/(*)/SmugMug/(*)!albums 
            return await folderuser___SmugMug____albums(string.Empty, string.Empty); 
        }

        public async Task<FolderListEntity> Fixup_folderuser___SmugMug____folderlist ()
        {
            // /folder/user/(*)/SmugMug/(*)!folderlist 
            return await folderuser___SmugMug____folderlist(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity[]> Fixup_folderuser___SmugMug____folders ()
        {
            // /folder/user/(*)/SmugMug/(*)!folders 
            return await folderuser___SmugMug____folders(string.Empty, string.Empty); 
        }

        public async Task<ImageEntity> Fixup_folderuser___SmugMug____highlightimage ()
        {
            // /folder/user/(*)/SmugMug/(*)!highlightimage 
            return await folderuser___SmugMug____highlightimage(string.Empty, string.Empty); 
        }

        public async Task<PageEntity[]> Fixup_folderuser___SmugMug____pages ()
        {
            // /folder/user/(*)/SmugMug/(*)!pages 
            return await folderuser___SmugMug____pages(string.Empty, string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderuser___SmugMug____parent ()
        {
            // /folder/user/(*)/SmugMug/(*)!parent 
            return await folderuser___SmugMug____parent(string.Empty, string.Empty); 
        }

        public async Task<SizeEntity> Fixup_folderuser___SmugMug____size ()
        {
            // /folder/user/(*)/SmugMug/(*)!size 
            return await folderuser___SmugMug____size(string.Empty, string.Empty); 
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
    }
}
