// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DownloadEntity : SmugMugEntity
    {
        public DownloadEntity()
        {
            //Empty constructor to enable deserialization
        }

        public DownloadEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public async Task<AlbumEntity> album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}", param1);

            return await RetrieveEntityAsync<AlbumEntity>(requestUri); 
        }
    }
}
