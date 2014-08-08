using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class Featured:SmugMugObject
    {
        /// <summary>
        ///  List of featured albums for a given user.
        /// </summary>
        public List<Album> Albums { get; set; }

        public Featured()
        {
            Albums = new List<Album>();
        }
    }
}
