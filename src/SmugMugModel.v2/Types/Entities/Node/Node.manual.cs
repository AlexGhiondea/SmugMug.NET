// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {
        public async Task<AlbumEntity> Considered_Fixup_album___()
        {
            // /album/(*) 
            return await album___(string.Empty);
        }

        public async Task<FolderEntity> GetFolderByIdAsync()
        {
            // /folder/id/(*) 
            return await folderid___(NodeID);
        }

        public async Task<ImageEntity> GetHighlightImageAsync()
        {
            // /highlight/node/(*) 
            return await highlightnode___(NodeID);
        }

        public async Task<NodeEntity[]> GetChildrenAsync()
        {
            // /node/(*)!children 
            return await node____children(NodeID);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /node/(*)!grants 
            return await node____grants(NodeID);
        }

        public async Task RequiresPost_Fixup_node____movenodes()
        {
            // /node/(*)!movenodes 
            await node____movenodes(string.Empty);
        }

        public async Task<NodeEntity> GetParentAsync()
        {
            // /node/(*)!parent 
            return await node____parent(NodeID);
        }

        public async Task<NodeEntity[]> GetParents()
        {
            // /node/(*)!parents 
            return await node____parents(NodeID);
        }

        //public async Task<UserEntity> Fixup_user___()
        //{
        //    // /user/(*) 
        //    return await user___(string.Empty);
        //}
    }
}
