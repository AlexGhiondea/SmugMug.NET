using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMug.v2.Types
{
    public class Pages
    {
        public int Total { get; set; }
        public int Start { get; set; }
        public int Count { get; set; }
        public int RequestedCount { get; set; }
        public string FirstPage { get; set; }
        public string LastPage { get; set; }
        public string NextPage { get; set; }
    }
}
