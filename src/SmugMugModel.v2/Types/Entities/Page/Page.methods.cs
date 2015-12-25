// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class PageEntity : SmugMugEntity
    {
        public PageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public PageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        private static readonly List<string> PatchParameters = new List<string>(){ "Name","UrlName","AutoRename","Password","PasswordHint","Privacy","SecurityType","HighlightImageUri" };

        private static readonly List<string> PostParameters = new List<string>(){ "Name", "UrlName", "AutoRename", "Password", "PasswordHint", "Privacy", "SecurityType" };
    }
}
