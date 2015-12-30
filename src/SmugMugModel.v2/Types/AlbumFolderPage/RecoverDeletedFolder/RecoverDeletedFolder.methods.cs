// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class RecoverDeletedFolderEntity : SmugMugEntity
    {
        public RecoverDeletedFolderEntity()
        {
            //Empty constructor to enable deserialization
        }

        public RecoverDeletedFolderEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        private static readonly List<string> PostParameters = new List<string>(){ "FolderUri", "IncludeChildren" };
    }
}
