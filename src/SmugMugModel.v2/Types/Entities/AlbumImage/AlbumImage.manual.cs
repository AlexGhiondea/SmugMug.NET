// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public partial class AlbumImageEntity : ImageEntity
    {
        public async Task<AlbumImageShareUrisEntity> GetShareUris()
        {
            // /album/(*)/image/(*)!shareuris 
            string requestUri = string.Format("{0}/album/{1}/image/{2}!shareuris", SmugMug.v2.Constants.Addresses.SmugMugApi, ParentEntity.EntityId, ImageKey);

            return await RetrieveEntityAsync<AlbumImageShareUrisEntity>(requestUri); 
        }
    }
}
