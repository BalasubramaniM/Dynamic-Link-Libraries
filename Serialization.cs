using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows;
using System.IO;
using HelperClass.Serialization; // Namespace to make use of Serialization class

namespace HelperClass.Serialization
{
    class Serialization
    {
        protected object DeserializeFromJson(object obj, string jsonString) // Converts JSON string to objects
        {
            return Serializer.Instance.DeserializeFromJson(obj, jsonString);
        }

        protected string SerializeToJson(object obj) // Converts objects to JSON string (in JSON format)
        {
            return Serializer.Instance.SerializeToJson(obj);
        }

        protected object DeserializeFromXML(object obj, string xmlString) // Converts XML data to objects
        {
            return Serializer.Instance.DeserializeFromXML(obj, xmlString);
        }

        protected string SerializeToXML(object obj) // Converts objects to XML value (in XML format)
        {
            return Serializer.Instance.SerializeToXML(obj);
        }

        public JObject JsonData { get; set; }
        protected void JsonValue()
        {
            JsonData = Serializer.Instance.RetrieveParsedJSONValue("JsonFileName.txt"); // Get parsed json data, when you pass json string to this function
        }
    }
}
