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
            //functions.ReadXml();
            //functions.ReadXmlWithXDocument();
            //functions.GetSingleElement();
            // functions.QueryXml();

            //functions.SerializeObjectToXmlString();
            functions.SerializeObjectToXmlFile();
        }


    }
}
