using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    /// <summary>
    /// Deprecated...I don't know if it's going to be used again (its not used now)
    /// </summary>
    [Obsolete]
    public class Product
    {
        #region Properties
        public long id { get; set; }
        #endregion

        /// <summary>
        /// The type of product. Values: "CommonPrint" "DigitalPrint" "Download" "Merchandise" "SpecialityPrint"
        /// </summary>
        private ProductTypeEnum myType;
        public ProductTypeEnum Type
        {
            get { return myType; }
            set { myType = value; }
        }
    }
}
