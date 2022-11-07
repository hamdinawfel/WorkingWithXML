using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WorkingWithXML.Models
{
    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPremium { get; set; } 
    }
}
