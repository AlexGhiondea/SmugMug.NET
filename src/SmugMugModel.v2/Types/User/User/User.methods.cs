// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        public UserEntity()
        {
            //Empty constructor to enable deserialization
        }

        public UserEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }

        private async Task<NodeEntity> CreateNodeEntity (string param1)
        {
            // /node/(*) 
            string requestUri = string.Format("{0}/node/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            var node = await RetrieveEntityAsync<NodeEntity>(requestUri);
            node.NodeId = param1;
            return node;
        }

        private async Task<ImageEntity[]> user____imagesearch (string param1)
        {
            // /user/(*)!imagesearch 
            string requestUri = string.Format("{0}/user/{1}!imagesearch", SmugMug.v2.Constants.Addresses.SmugMugApi, param1);

            return await RetrieveEntityArrayAsync<ImageEntity>(requestUri); 
        }
    }
}
