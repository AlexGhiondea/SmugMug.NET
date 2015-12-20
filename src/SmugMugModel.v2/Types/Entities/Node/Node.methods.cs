// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {
        public NodeEntity()
        {
            //Empty constructor to enable deserialization
        }

        public NodeEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public AlbumEntity album___ (string param1)
        {
            // /album/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/album/{0}", param1);

            return RetrieveEntityAsync<AlbumEntity>(requestUri).Result; 
        }

        public FolderEntity folderid___ (string param1)
        {
            // /folder/id/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/folder/id/{0}", param1);

            return RetrieveEntityAsync<FolderEntity>(requestUri).Result; 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/highlight/node/{0}", param1);

            return RetrieveEntityAsync<ImageEntity>(requestUri).Result; 
        }

        public NodeEntity[] node____children (string param1)
        {
            // /node/(*)!children 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}!children", param1);

            return RetrieveEntityArrayAsync<NodeEntity>(requestUri).Result; 
        }

        public GrantEntity[] node____grants (string param1)
        {
            // /node/(*)!grants 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}!grants", param1);

            return RetrieveEntityArrayAsync<GrantEntity>(requestUri).Result; 
        }

        public void node____movenodes (string param1)
        {
            // /node/(*)!movenodes 
            return; 
        }

        public NodeEntity node____parent (string param1)
        {
            // /node/(*)!parent 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}!parent", param1);

            return RetrieveEntityAsync<NodeEntity>(requestUri).Result; 
        }

        public NodeEntity[] node____parents (string param1)
        {
            // /node/(*)!parents 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/node/{0}!parents", param1);

            return RetrieveEntityArrayAsync<NodeEntity>(requestUri).Result; 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            string requestUri = string.Format("https://api.smugmug.com/api/v2/user/{0}", param1);

            return RetrieveEntityAsync<UserEntity>(requestUri).Result; 
        }
    }
}
