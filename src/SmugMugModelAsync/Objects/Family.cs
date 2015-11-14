using System;
using System.Collections.Generic;
using System.Text;

namespace SmugMugModel
{
    public class Family
    {
        #region Properties
        /// <summary>
        /// The DisplayName for this user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The NickName for this user.
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// The homepage URL for this user.
        /// </summary>
        public string URL { get; set; }
        #endregion
    }
}
