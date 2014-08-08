using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    /// <summary>
    /// The style template applied to this album
    /// </summary>
    public class Template
    {
        /// <summary>
        /// Values: 0-Viewer Choice =default, 3-SmugMug, 4-Traditional, 7-All Thumbs, 8-Slideshow, 9-Journal, 10-SmugMug Small, 11-Filmstrip, 12-Critique
        /// </summary>
        public long id { get; set; }
        public string Name { get; set; }
    }
}
