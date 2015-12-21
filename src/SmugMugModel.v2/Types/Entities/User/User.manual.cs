// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using SmugMug.v2.Authentication;

namespace SmugMug.v2.Types
{
    public partial class UserEntity : SmugMugEntity
    {
        public async Task<AlbumEntity[]> GetAlbumsAsync()
        {
            return await user____albums(this.NickName);
        }

        public async Task<BioImageEntity> GetBioImageAsync()
        {
            return await user____bioimage(this.NickName);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
