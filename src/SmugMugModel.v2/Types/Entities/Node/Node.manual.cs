// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {

        public async Task<AlbumEntity> Fixup_album___ ()
        {
            // /album/(*) 
            return await album___(string.Empty); 
        }

        public async Task<FolderEntity> Fixup_folderid___ ()
        {
            // /folder/id/(*) 
            return await folderid___(string.Empty); 
        }

        public async Task<ImageEntity> Fixup_highlightnode___ ()
        {
            // /highlight/node/(*) 
            return await highlightnode___(string.Empty); 
        }

        public async Task<NodeEntity[]> Fixup_node____children ()
        {
            // /node/(*)!children 
            return await node____children(string.Empty); 
        }

        public async Task<GrantEntity[]> Fixup_node____grants ()
        {
            // /node/(*)!grants 
            return await node____grants(string.Empty); 
        }

        public async Task Fixup_node____movenodes ()
        {
            // /node/(*)!movenodes 
            await node____movenodes(string.Empty); 
        }

        public async Task<NodeEntity> Fixup_node____parent ()
        {
            // /node/(*)!parent 
            return await node____parent(string.Empty); 
        }

        public async Task<NodeEntity[]> Fixup_node____parents ()
        {
            // /node/(*)!parents 
            return await node____parents(string.Empty); 
        }

        public async Task<UserEntity> Fixup_user___ ()
        {
            // /user/(*) 
            return await user___(string.Empty); 
        }
    }
}
