// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class LargestImageEntity : SmugMugEntity
    {

        public async Task<ImageSizeX3LargeEntity> Fixup_image____sizex3large ()
        {
            // /image/(*)!sizex3large 
            return await image____sizex3large(string.Empty); 
        }

        public async Task<ImageSizeOriginalEntity> Fixup_image____sizeoriginal ()
        {
            // /image/(*)!sizeoriginal 
            return await image____sizeoriginal(string.Empty); 
        }

        public async Task<ImageSizeXLargeEntity> Fixup_image____sizexlarge ()
        {
            // /image/(*)!sizexlarge 
            return await image____sizexlarge(string.Empty); 
        }
    }
}
