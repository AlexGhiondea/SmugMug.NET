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


        public FolderEntity folderid___ (string param1)
        {
            // /folder/id/(*) 
            return default(FolderEntity); 
        }

        public NodeEntity[] node____parents (string param1)
        {
            // /node/(*)!parents 
            return default(NodeEntity[]); 
        }

        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public ImageEntity highlightnode___ (string param1)
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public NodeEntity[] node____children (string param1)
        {
            // /node/(*)!children 
            return default(NodeEntity[]); 
        }

        public NodeEntity node____parent (string param1)
        {
            // /node/(*)!parent 
            return default(NodeEntity); 
        }

        public AlbumEntity album___ (string param1)
        {
            // /album/(*) 
            return default(AlbumEntity); 
        }
    }
}
