using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    public class SmugMugException : Exception
    {
        public int code { get; set; }
        public string method { get; set; }

        public SmugMugException() { }

        public SmugMugException(int cod, string msg, string meth) : base(msg)
        {
            code = cod;
            method = meth;
        }
    }

}
