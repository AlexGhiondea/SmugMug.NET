using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class Restrictions
    {
        /// <summary>
        /// List of Albums containing their Id and Key
        /// </summary>
        public List<Album> Albums { get; set; }

        public Restrictions()
        {
            Albums = new List<Album>();
        }
    }
}
