// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMugCodeGen
{
    public static class Constants
    {
        public const string PropertyDefinition = @"public {0} {1} {{get; set;}}";

        public const string EnumDefinition = @"// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SmugMug.v2.Types
{{
    public enum {0} 
    {{
        {1}
    }}
}}
";

        public const string ClassDefinition = @"// Copyright (c) Alex Ghiondea. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace SmugMug.v2.Types
{{
    public partial class {0}Entity
    {{
        {1}
    }}
}}
";
    }
}
