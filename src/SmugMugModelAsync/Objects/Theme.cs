using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class Theme
    {
        #region Properties
        /// <summary>
        /// The id for this theme.
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this theme
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The type of the theme (Values: "smugmug", "user")
        /// </summary>
        public ThemeType Type { get; set; }
        #endregion
    }
}
