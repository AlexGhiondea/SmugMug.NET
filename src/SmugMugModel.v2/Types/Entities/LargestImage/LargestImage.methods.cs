// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {
        public LargestImageEntity()
        {
            //Empty constructor to enable deserialization
        }

        public LargestImageEntity(OAuthToken oauthToken)
            : base(oauthToken)
        {
            _oauthToken = oauthToken;
        }


        public ImageSizeOriginalEntity image____sizeoriginal (string param1)
        {
            // /image/(*)!sizeoriginal 
            return default(ImageSizeOriginalEntity); 
        }

        public ImageSizeXLargeEntity image____sizexlarge (string param1)
        {
            // /image/(*)!sizexlarge 
            return default(ImageSizeXLargeEntity); 
        }

        public ImageSizeX3LargeEntity image____sizex3large (string param1)
        {
            // /image/(*)!sizex3large 
            return default(ImageSizeX3LargeEntity); 
        }
    }
}
