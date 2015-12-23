//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmugMugTest.v2
//{
//    class CodeGen
//    {
//    }

//    // -1 represents infinite
//    public class Limits
//    {
//        public int Min { get; set; }
//        public int Max { get; set; }
//        public static readonly Limits None = null;
//    }

//    public class MethodDescriptor
//    {
//        public string Description { get; set; } 	// From Notes
//        public string MethodType { get; set; }
//        public string RequiredPermissions { get; set; } // MethodDetails / [methodType] / Permissions
//        public string LocatorType { get; set; }

//        public List<PropertyDescriptor> Properties { get; set; }
//    }

//    public class PropertyType
//    {
//        public string Name; // Select, nvarchar, etc
//        public string Description; //ParameterDescription -- how the type looks like
//    }

//    public class PropertyDescriptor
//    {
//        public string PropertyName;
//        public string Description;
//        public bool IsRequired;
//        public bool IsReadOnly;
//        public string DefaultValue;

//        public PropertyType Type;

//        public string Deprecated; // a string containing the date since when this property has been deprecated.
//    }

//    public class StringPropertyDescriptor : PropertyDescriptor
//    {
//        public Limits PropertyLimits; // we can use this to enforce seting it.	
//    }

//    public class SelectPropertyDescriptor : PropertyDescriptor
//    {
//        public List<string> TypeProperties { get; set; } // If the type is select, this will have the available values in it
//        // NOTE: We should try and unify as many as these types as possible so that we reduce the type duplication		
//    }

//    public class DecimalPropertyDescriptor : PropertyDescriptor
//    {
//        public int Precision;
//        public int Scale;
//        public bool Signed;
//    }

//    public class IntegerPropertyDescriptor : PropertyDescriptor
//    {
//        public Limits IntegerLimits;
//    }

//    public class BooleanPropertyDescriptor : PropertyDescriptor
//    {

//    }

//    public class ArrayPropertyDescriptor : PropertyDescriptor
//    {
//        public string ItemType; // one of varchar, select, etc
//        public Limits ArrayLimits;
//    }

//}
