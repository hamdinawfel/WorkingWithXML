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
            Console.WriteLine("Working with xml files");
            var functions = new Functions();
            //functions.ReadXml();
            //functions.ReadXmlWithXDocument();
            //functions.GetSingleElement();
            // functions.QueryXml();

            

            var todaysDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            Console.WriteLine(todaysDate == "2022-11-07 08:39:58.7280291");

        }


    }
}
