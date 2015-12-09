using System;
using System.Collections.Generic;
using System.Text;

namespace SmugMugModel
{
    public class Comment
    {
        #region Properties
        /// <summary>
        /// The id for this comment
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// The date that this comment was posted
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// The rating for this comment. Values:  0 - No Rating, 1 - 1 Star Rating, 2 - 2 Star Rating, 3 - 3 Star Rating, 4 - 4 Star Rating, 5 - 5 Star Rating
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// The text for this comment
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The type for this comment. Values: "SmugMug", "Facebook"
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Name (string) - The name for this user.
        /// URL (string)  - The homepage URL for this user.
        /// </summary>
        public User User { get; set; }        
        #endregion Properties

        public Comment()
        {
            User = new User();
        }
    }
}
