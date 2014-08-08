using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class Community : SmugMugObject
    {
        #region Properties
        /// <summary>
        /// The id for this community
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The name for this community
        /// </summary>
        public string Name { get; set; }
        #endregion
    }
}
