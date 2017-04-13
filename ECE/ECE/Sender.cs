using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Sender : IOrganization
    {
        [XmlAttribute]
        public string Organization { get; set; }
        [XmlAttribute]
        public string Department { get; set; }
        [XmlAttribute]
        public string Position { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Code { get; set; }
        public Sender()
        {

        }
        public Sender(string organization, string code)
        {
            Organization = organization;
            Code = code;
        }
        public Sender(string organization,string department,string position, string name, string code)
        {
            Organization = organization;
            Department = department;
            Position = position;
            Name = name;
            Code = code;
        }
    }
}
