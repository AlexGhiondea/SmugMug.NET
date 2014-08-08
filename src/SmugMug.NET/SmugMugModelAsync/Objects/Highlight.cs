using System;
using System.Collections.Generic;
using System.Text;

namespace SmugMugModel
{
    public class Highlight
    {
        #region Properties
        /// <summary>
        /// The id for this highlight image
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The key for this highlight image
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// The type for this highlight image. Values: Featured, Random
        /// </summary>
        public string Type { get; set; }
        #endregion
    }
}
