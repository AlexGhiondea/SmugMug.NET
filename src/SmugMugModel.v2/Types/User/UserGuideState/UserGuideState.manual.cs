// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserGuideStateEntity : SmugMugEntity
    {

        public async Task<GuideEntity> Fixup_guide___ ()
        {
            // /guide/(*) 
           // return await guide___(string.Empty);

            // /guide/(*) 
            string requestUri = string.Format("{0}/guide/{1}", SmugMug.v2.Constants.Addresses.SmugMugApi, EntityId);

            return await RetrieveEntityAsync<GuideEntity>(requestUri);
        }
    }
}
