// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DownloadEntity : SmugMugEntity
    {

        public async Task<AlbumEntity> GetAlbumAsync ()
        {
            // /album/(*) 
           // return await album___();

            // /album/(*) 
            string requestUri = string.Format("{0}/album/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, Parent.EntityId);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri);
        }
    }
}
