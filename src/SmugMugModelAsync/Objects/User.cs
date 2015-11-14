using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class User
    {
        #region Properties
        /// <summary>
        /// The id for this user.
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The NickName for this user.
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// The DisplayName for this user.
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The name for this user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The homepage URL for this user.
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// Albums with stats
        /// </summary>
        public List<Album> Albums { get; set; }
        /// <summary>
        /// The bytes transferred for this user for a given month
        /// </summary>
        public int Bytes { get; set; }
        /// <summary>
        /// The total hits for this user for a given month
        /// </summary>
        public int Hits { get; set; }
        /// <summary>
        /// The number of Large hits for this user for a given month
        /// </summary>
        public int Large { get; set; }
        /// <summary>
        /// The number of Medium hits for this user for a given month
        /// </summary>
        public int Medium { get; set; }
        /// <summary>
        /// The number of Original hits for this user for a given month
        /// </summary>
        public int Original { get; set; }
        /// <summary>
        /// The number of Small hits for this user for a given month
        /// </summary>
        public int Small { get; set; }
        /// <summary>
        /// The number of Video1280 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video1280 { get; set; }
        /// <summary>
        /// The number of Video1920 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video1920 { get; set; }
        /// <summary>
        /// The number of Video320 hits for this user for a given month (power and pro accounts only)
        /// </summary>
        public int? Video320 { get; set; }  
        /// <summary>
        /// The number of Video640 hits for this user for a given month (power and pro accounts only)
        /// </summary>
        public int? Video640 { get; set; }
        /// <summary>
        /// The number of Video960 hits for this user for a given month (pro accounts only)
        /// </summary>
        public int? Video960 { get; set; }
        /// <summary>
        /// The number of X2Large hits for this user for a given month
        /// </summary>
        public int X2Large { get; set; }
        /// <summary>
        /// The number of X3Large hits for this user for a given month
        /// </summary>
        public int X3Large { get; set; }
        /// <summary>
        /// The number of XLarge hits for this user for a given month
        /// </summary>
        public int XLarge { get; set; }
        #endregion

        public User()
        {
            Albums = new List<Album>();
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}
