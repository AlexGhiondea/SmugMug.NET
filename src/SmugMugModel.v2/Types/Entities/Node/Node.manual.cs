// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;
using System.Collections.Generic;
using System.Linq;
using SmugMug.v2.Utility;
using SmugMug.v2.Types.Enums;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {
        public async Task<AlbumEntity> Considered_Fixup_album___()
        {
            // /album/(*) 
            // return await album___(string.Empty);

            // /album/(*) 
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, string.Empty);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri);
        }

        public async Task<FolderEntity> AsFolderAsync()
        {
            // /folder/id/(*) 
            //return await folderid___(NodeId);
            // /folder/id/(*) 
            string requestUri = string.Format("{0}/folder/id/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);

            return await RetrieveEntityAsync<FolderEntity>(requestUri);

        }

        public async Task<ImageEntity> GetHighlightImageAsync()
        {
            // /highlight/node/(*) 
            //return await highlightnode___(NodeId);

            // /highlight/node/(*) 
            string requestUri = string.Format("{0}/highlight/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);

            return await RetrieveEntityAsync<ImageEntity>(requestUri);
        }

        public async Task<NodeEntity[]> GetChildrenAsync(NodeSortMethodEnum sortMethod = NodeSortMethodEnum.Organizer, SortDirectionEnum sortDirection = SortDirectionEnum.Ascending, TypeEnum type = TypeEnum.All)
        {
            // /node/(*)!children 
            //return await node____children(NodeId, $"SortDirection={sortDirection}&SortMethod={sortMethod}&Type={type}");

            string options = $"SortDirection={sortDirection}&SortMethod={sortMethod}&Type={type}";

            // /node/(*)!children 
            string requestUri = string.Format("{0}/node/{1}!children{2}", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId, string.IsNullOrEmpty(options) ? "" : $"?{options}");

            return await RetrieveEntityArrayAsync<NodeEntity>(requestUri);
        }

        public async Task<NodeEntity[]> GetChildrenAsync()
        {
            return await GetChildrenAsync(NodeSortMethodEnum.Organizer, SortDirectionEnum.Ascending, TypeEnum.All);
        }

        public async Task<GrantEntity[]> GetGrantsAsync()
        {
            // /node/(*)!grants 
            //return await node____grants(NodeId);

            // /node/(*)!grants 
            string requestUri = string.Format("{0}/node/{1}!grants", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);

            return await RetrieveEntityArrayAsync<GrantEntity>(requestUri);
        }

        public async Task MoveNodesAsync(IEnumerable<NodeEntity> nodes, bool asyncMove, bool autoRename = true)
        {
            var nodeUris = nodes.Select(node => node.Uri).ToArray();
            var postProperties = new List<KeyValuePair<string, object>>();
            postProperties.Add(new KeyValuePair<string, object>("Async", asyncMove));
            postProperties.Add(new KeyValuePair<string, object>("AutoRename", autoRename));
            postProperties.Add(new KeyValuePair<string, object>("MoveUris", nodeUris));

            var payload = JsonHelpers.GetPayloadAsJson(postProperties);

            string requestUri = string.Format("{0}/node/{1}!movenodes", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);
            await PostRequestAsync(requestUri, payload);
        }

        public async Task<NodeEntity> GetParentAsync()
        {
            // /node/(*)!parent 
            //return await node____parent(NodeId);

            // /node/(*)!parent 
            string requestUri = string.Format("{0}/node/{1}!parent", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);

            return await RetrieveEntityAsync<NodeEntity>(requestUri);
        }

        public async Task<NodeEntity[]> GetParents()
        {
            // /node/(*)!parents 
            //return await node____parents(NodeId);

            // /node/(*)!parents 
            string requestUri = string.Format("{0}/node/{1}!parents", SmugMug.v2.Constants.Addresses.SmugMugApi, NodeId);

            return await RetrieveEntityArrayAsync<NodeEntity>(requestUri);
        }

        //public async Task<UserEntity> Fixup_user___()
        //{
        //    // /user/(*) 
        //    return await user___(string.Empty);
        //}
    }
}
