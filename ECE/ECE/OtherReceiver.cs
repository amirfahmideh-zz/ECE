using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class OtherReceiver : IOrganization
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
        [XmlAttribute]
        public ReceiveType ReceiveType { get; set; }
        public OtherReceiver()
        {

        }
        public OtherReceiver(string organization, string code, ReceiveType receiveType)
        {
            Organization = organization;
            Code = code;
            ReceiveType = receiveType;
        }
        public OtherReceiver(string organization, string department, string position, string name, string code, ReceiveType receiveType)
        {
            Organization = organization;
            Department = department;
            Position = position;
            Name = name;
            Code = code;
            ReceiveType = receiveType;
        }
    }
}
