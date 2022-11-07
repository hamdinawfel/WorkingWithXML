using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WorkingWithXML.Models;

namespace WorkingWithXML
{
    public class Functions
    {
        public void ReadXml()
        {
            XElement xelement = XElement.Load("assets\\example1.xml");

            IEnumerable<XElement> invoices = xelement.Elements();

            foreach (var invoice in invoices)
            {
                Console.WriteLine(invoice);
            }
        }
        public void ReadXmlWithXDocument()
        {
            XDocument xdocument = XDocument.Load("assets\\example1.xml");
            IEnumerable<XElement> invoiceItems = xdocument.Root.Elements();
            foreach (var item in invoiceItems)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

        public void GetSingleElement()
        {
            XElement xelement = XElement.Load("assets\\example1.xml");

            IEnumerable<XElement> invoice = xelement.Elements();

            foreach (var item in invoice)
            {
                var invoiceNumber = item.Element("AccountingSupplierParty").Value;
                Console.WriteLine(invoiceNumber);
            }

        }

        public void QueryXml()
        {
            var filePath = "assets\\Presedent.xml";
            var presedentData = XElement.Load(filePath);

            var presendents = presedentData.Descendants("Folder");
            foreach(var presendent in presendents)
            {
                Console.WriteLine($"{presendent.Element("StdName").Value}");
                foreach(var item in presendent.Descendants("contact"))
                {
                    Console.WriteLine($"Email:  {item.Element("email").Value}");
                }
                var election = presendent.Descendants("Election").Descendants("Year");
                foreach (var item in election)
                {
                    Console.WriteLine($"{    item.Attribute("Title").Value}   :  {item.Value}");
                }
            }

        }
        
        public void SerializeObjectToXmlString()
        {
            var member = new Member{
                Name = "Hamdi Nawfel",
                Email = "Hamdi.Nawfel@tn.ey.com",
                Age = 31,
                CreatedAt = DateTime.Now,
                IsPremium = true,   
            };

            var xmlSerilizer = new XmlSerializer(typeof(Member));

            using (var writer = new StringWriter())
            {
                xmlSerilizer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
            };
        }

        public void SerializeObjectToXmlFile()
        {
            var member = new Member
            {
                Name = "Hamdi Nawfel",
                Email = "Hamdi.Nawfel@tn.ey.com",
                Age = 31,
                CreatedAt = DateTime.Now,
                IsPremium = true,
            };

            var xmlSerilizer = new XmlSerializer(typeof(Member));

            using (var writer = new StreamWriter(@"C:\Users\AX412BC\workspace\WorkingWithXML\WorkingWithXML\assets\member.xml"))
            {
                xmlSerilizer.Serialize(writer, member);
                Console.WriteLine("Process Completed");
            };
        }


    }
}
