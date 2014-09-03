using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperClass.Serialization; // Namespace to make use of Serialization class

namespace Controls.Model
{
    class Serialization
    {
        protected object DeserializeFromJson(object obj, string jsonString) // Converts JSON string to objects
        {
            return Serializer.Serialize.DeserializeFromJson(obj, jsonString);
        }

        protected string SerializeToJson(object obj) // Converts objects to JSON string (in JSON format)
        {
            return Serializer.Serialize.SerializeToJson(obj);
        }

        protected object DeserializeFromXML(object obj, string xmlString) // Converts XML data to objects
        {
            return Serializer.Serialize.DeserializeFromXML(obj, xmlString);
        }

        protected string SerializeToXML(object obj) // Converts objects to XML value (in XML format)
        {
            return Serializer.Serialize.SerializeToXML(obj);
        }
    }
}
