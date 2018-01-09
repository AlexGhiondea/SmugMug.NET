using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public class UriDescriptor
    {
        public string Uri { get; set; }
        public string Locator { get; set; }
        public string LocatorType { get; set; }
        public string UriDescription { get; set; }
        public string EndpointType { get; set; }
    }
}
