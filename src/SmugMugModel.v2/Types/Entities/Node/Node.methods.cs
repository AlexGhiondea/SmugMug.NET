// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{
    public partial class NodeEntity : SmugMugEntity
    {

        public FolderEntity folderid___ ()
        {
            // /folder/id/(*) 
            return default(FolderEntity); 
        }

        public NodeEntity node____parents ()
        {
            // /node/(*)!parents 
            return default(NodeEntity); 
        }

        public UserEntity user___ ()
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public ImageEntity highlightnode___ ()
        {
            // /highlight/node/(*) 
            return default(ImageEntity); 
        }

        public NodeEntity node____children ()
        {
            // /node/(*)!children 
            return default(NodeEntity); 
        }

        public NodeEntity node____parent ()
        {
            // /node/(*)!parent 
            return default(NodeEntity); 
        }

        public AlbumEntity album___ ()
        {
            // /album/(*) 
            return default(AlbumEntity); 
        }

    }
}
