// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class ImageSizesEntity : SmugMugEntity
    {
        public override string EntityId
        {
            get
            {
                //TODO: This is not necessarily the best way to do this.
                return this.Parent.EntityId;
            }
        }
        public ImageSizesEntity()
        {
            //Empty constructor to enable deserialization
        }

        public ImageSizesEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }
    }
}
