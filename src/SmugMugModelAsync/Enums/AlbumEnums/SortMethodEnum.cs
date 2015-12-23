using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmugMugModel
{
    //The method used for sorting images within this album
       public enum SortMethod
        {
           Position,         //None (default)
           Caption,          //By caption
           FileName,         //By filenames
           Date,             //By date uploaded
           DateTime,         //By date modified (if available)
           DateTimeOriginal, //By date taken (if available)
        };
}
