// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;
using System.Collections.Generic;
using System.Linq;
using SmugMug.v2.Utility;

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

        public async Task MoveNodesAsync(IEnumerable<NodeEntity> nodes, bool asyncMove, bool autoRename = true)
        {
            var nodeUris = nodes.Select(node => node.Uri).ToArray();
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Async", asyncMove));
            postProperties.Add(new KeyValuePair<string, object>("AutoRename", autoRename));
            postProperties.Add(new KeyValuePair<string, object>("MoveUris", nodeUris));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            string requestUri = string.Format("{0}/node/{1}!movenodes", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeID);
            await PostRequestAsync(requestUri, payload);
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
