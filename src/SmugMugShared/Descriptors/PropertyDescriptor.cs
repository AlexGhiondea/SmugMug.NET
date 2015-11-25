using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmugMugTest.Shared.Descriptors
{
    public static class Extensions
    {
        public static string GetValueAsString(this JObject obj, string name)
        {
            var prop = obj.Property(name);
            if (prop != null)
                return prop.Value.ToString();

            return string.Empty;
        }
    }


    public class Limits
    {
        // INFINITY, NEGATIVE_INFINITY, POSITIVE_INFINITY

        public string Min { get; set; }
        public string Max { get; set; }
    }

    public class PropertyDescriptor
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Deprecated { get; set; }

        public PropertyDescriptor(JObject obj)
        {
            Name = obj.GetValueAsString("Name");
            Description = obj.GetValueAsString("Description");
            Deprecated = obj.GetValueAsString("Deprecated");
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ArrayPropertyDescriptor : PropertyDescriptor
    {
        public string ItemType { get; set; }
        public Limits ArrayLimits { get; set; }

        public ArrayPropertyDescriptor(JObject obj)
            : base(obj)
        {
            ItemType = obj.GetValueAsString("ITEM_TYPE");

            var min = obj.Property("MIN_COUNT").ToObject<string>();
            var max = obj.Property("MAX_COUNT").ToObject<string>();
            ArrayLimits = new Limits() { Min = min, Max = max };
        }

        public override string ToString()
        {
            return base.ToString() + ": Array (of" + ItemType + ")";
        }
    }

    public class TimeStampPropertyDescriptor : PropertyDescriptor
    {
        public TimeStampPropertyDescriptor(JObject obj)
            : base(obj)
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": TimeStamp";
        }
    }

    public class DateTimePropertyDescriptor : PropertyDescriptor
    {
        public DateTimePropertyDescriptor(JObject obj)
            : base(obj)
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": DateTime";
        }
    }

    public class HashPropertyDescriptor : PropertyDescriptor
    {
        public HashPropertyDescriptor(JObject obj)
            : base(obj)
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": Hash";
        }
    }

    public class DecimalPropertyDescriptor : PropertyDescriptor
    {
        public string Precision { get; set; }
        public string Scale { get; set; }
        public bool Signed { get; set; }

        public DecimalPropertyDescriptor(JObject obj)
            : base(obj)
        {
            Precision = obj.Property("PRECISION").ToObject<string>();
            Scale = obj.Property("SCALE").ToObject<string>();
            Signed = obj.Property("SIGNED").ToObject<bool>();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": Decimal ({0}, {1}), {2}", Precision, Scale, Signed ? "signed" : "unsigned");
        }
    }

    public class SelectPropertyDescriptor : PropertyDescriptor
    {
        public Limits OptionCountLimits { get; set; }

        public List<string> Options { get; set; }

        public SelectPropertyDescriptor(JObject obj)
            : base(obj)
        {
            var min = obj.Property("MIN_COUNT").ToObject<string>();
            var max = obj.Property("MAX_COUNT").ToObject<string>();
            OptionCountLimits = new Limits() { Min = min, Max = max };

            Options = new List<string>((obj.Property("OPTIONS").Value as JArray).Values().Select(x => x.ToString()));
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": Select {{{0}}}", string.Join(",", Options));
        }
    }

    public class StringPropertyDescriptor : PropertyDescriptor
    {
        public Limits StringLimits { get; set; }
        public StringPropertyDescriptor(JObject obj)
            : base(obj)
        {

            string min = string.Empty, max = string.Empty;
            if (obj.Property("MIN_CHARS") != null)
            {
                min = obj.Property("MIN_CHARS").ToObject<string>();
            }

            if (obj.Property("MIN_CHARS") != null)
            {
                max = obj.Property("MAX_CHARS").ToObject<string>();
            }
            StringLimits = new Limits() { Min = min, Max = max };
        }

        public override string ToString()
        {
            return base.ToString() + ": string";
        }
    }

    public class IntegerPropertyDescriptor : PropertyDescriptor
    {
        public Limits IntegerLimits { get; set; }
        public IntegerPropertyDescriptor(JObject obj)
            : base(obj)
        {
            //TODO: This needs to be parsed as an int wrapper
            var min = obj.Property("MIN_VALUE").ToObject<string>();
            var max = obj.Property("MAX_VALUE").ToObject<string>();

            IntegerLimits = new Limits() { Min = min, Max = max };
        }

        public override string ToString()
        {
            return base.ToString() + ": integer";
        }
    }

    public class UriPropertyDescriptor : PropertyDescriptor
    {
        public Limits UriLimits { get; set; }
        public UriPropertyDescriptor(JObject obj)
            : base(obj)
        {
            var min = obj.GetValueAsString("MIN_LENGTH");
            var max = obj.GetValueAsString("MAX_LENGTH");

            UriLimits = new Limits() { Min = min, Max = max };
        }

        public override string ToString()
        {
            return base.ToString() + ": Uri";
        }
    }

    public class BooleanPropertyDescriptor : PropertyDescriptor
    {
        public BooleanPropertyDescriptor(JObject obj)
            : base(obj)
        {

        }

        public override string ToString()
        {
            return base.ToString() + ": bool";
        }
    }
}
