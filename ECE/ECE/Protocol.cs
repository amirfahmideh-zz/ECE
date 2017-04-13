using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Protocol
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Version { get; set; }
        public Protocol()
        {

        }
        public Protocol(string name = "ECE", string version = "1.01")
        {
            Name = name;
            Version = version;
        }
    }
}
