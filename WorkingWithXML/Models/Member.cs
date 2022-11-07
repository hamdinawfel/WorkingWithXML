using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WorkingWithXML.Models
{
    [Serializable]
    [XmlRoot("MemberDetails")]
    public class Member
    {
        [XmlElement("MemberName")]
        public string Name { get; set; }
        [XmlElement("MemberEmailAddress")]
        public string Email { get; set; }
        public int Age { get; set; }
        [XmlIgnore]
        public DateTime CreatedAt { get; set; }
        [XmlAttribute("PremiumMember")]
        public bool IsPremium { get; set; } 

    }
}
