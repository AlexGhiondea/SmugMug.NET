using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugTest.v2.PropertyDescriptors
{
    public class ObjectDescriptor
    {
        public string Name { get; set; }
        public List<PropertyDescriptor> Properties { get; set; }

        public List<MethodDescriptor> Methods { get; set; }

        public ObjectDescriptor()
        {
            Methods = new List<MethodDescriptor>();
        }
    }

    public class MethodDescriptor
    {
        public string NormalizedUri { get; set; }
        public string Uri { get; set; }
        public string ReturnType { get; set; }
    }
}
