// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {

        public async Task<ImageSizeX3LargeEntity> GetImageSizeX3LargeAsync()
        {
            // /image/(*)!sizex3large 
            return await image____sizex3large(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeOriginalEntity> GetImageSizeOriginalAsync()
        {
            // /image/(*)!sizeoriginal 
            return await image____sizeoriginal(ParentEntity.EntityId + "-0");
        }

        public async Task<ImageSizeXLargeEntity> GetImageSizeXLargeAsync()
        {
            // /image/(*)!sizexlarge 
            return await image____sizexlarge(ParentEntity.EntityId + "-0");
        }
    }
}
