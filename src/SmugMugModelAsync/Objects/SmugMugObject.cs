using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Net;

namespace SmugMugModel
{
    public class SmugMugObject
    {
        protected internal SmugMugBase basic { get; set; }

        public SmugMugObject()
        {
            basic = new SmugMugBase();
        }

        /// <summary>
        /// Builds a properties value list to send to smugmug in order to get a response
        /// </summary>
        /// <param name="obj">Object from which to take the properties</param>
        /// <param name="sendNot">Property name that you do not want to send</param>
        /// <returns></returns>
        protected List<String> BuildPropertiesValueList (Object obj, params string[] sendNot)    
        {
            Type myType = obj.GetType();
            var typeProperties = myType.GetProperties();
            List<String> propertiesList = new List<String>();
            if (typeProperties != null)
            {
                foreach (var myProperty in typeProperties)
                {
                    if (!(sendNot.Contains(myProperty.Name)) && (myProperty.GetValue(obj, null) != null))
                    {
                        propertiesList.Add(myProperty.Name);
                        propertiesList.Add(myProperty.GetValue(obj, null).ToString());
                    }
                }
            }
            return propertiesList;
        }

        /// <summary>
        /// Populates the current object with data from the response instead of creating a new object
        /// </summary>
        /// <param name="obj">Object from which you take the properties</param>
        /// <param name="returnObj">Object to which you asign the properties of object obj</param>
        protected void PopulateWithResponse(Object obj, Object returnObj, params string[] sendNot)
        {
            Type myType = obj.GetType();
            var typeProperties = myType.GetProperties();
            if (typeProperties != null)
            {
                foreach (var myProperty in typeProperties)
                {
                    if (!sendNot.Contains(myProperty.Name))
                    {
                        var propertyValue = myProperty.GetValue(obj, null);
                        //we don't want to override non-null members on obj with null members from returnObj
                        if (propertyValue != null)
                            myProperty.SetValue(returnObj, propertyValue, null);
                    }
                }
            }
        }
    }
}
