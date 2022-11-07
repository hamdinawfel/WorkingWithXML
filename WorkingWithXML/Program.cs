using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace WorkingWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var functions = new Functions();

            // FUNDAMANTALS

            //functions.ReadXml();
            //functions.ReadXmlWithXDocument();
            //functions.GetSingleElement();
            // functions.QueryXml();

            //SERIALIZATION

            //functions.SerializeObjectToXmlString();
            //functions.SerializeObjectToXmlFile();
            //functions.SerializeListObjectToXmlFile();
            //functions.DeserialzeXmlFileToObject();
            functions.DeserialzeXmlFileToObject();
        }
    }
}
