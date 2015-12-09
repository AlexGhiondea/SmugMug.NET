using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    /// <summary>
    /// Basic Information that must be send with each object
    /// </summary>
    public class SmugMugBase
    {
        /// <summary>
        /// The oAuth token
        /// </summary>
        public Token AccessToken { get; set; }
        /// <summary>
        /// The NickName for this user.
        /// </summary>
        public string NickName { set; get; }
    }
}