// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class FolderListEntity : SmugMugEntity
    {
        [Obsolete]
        public async Task<AlbumEntity[]> GetAlbumsAsync()
        {
            // /folder/user/(*)/(*)!albums 
            string requestUri = string.Format("{0}{1}!albums", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityArrayAsync<AlbumEntity>(requestUri);
        }

        public async Task<FolderEntity> GetFolderAsync()
        {
            // /folder/user/(*)/(*)!albums 
            string requestUri = string.Format("{0}{1}", SmugMug.v2.Constants.Addresses.SmugMug, Uri);

            return await RetrieveEntityAsync<FolderEntity>(requestUri);
        }
    }
}
