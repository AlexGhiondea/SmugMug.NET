// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class DeletedFolderEntity : SmugMugEntity
    {
        public DeletedFolderEntity()
        {
            //Empty constructor to enable deserialization
        }

        public DeletedFolderEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public UserEntity user___ (string param1)
        {
            // /user/(*) 
            return default(UserEntity); 
        }

        public RecoverDeletedFolderEntity deletedfolder____recover (string param1)
        {
            // /deleted/folder/(*)!recover 
            return default(RecoverDeletedFolderEntity); 
        }
    }
}
