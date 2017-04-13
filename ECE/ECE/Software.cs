using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Software
    {
        [XmlAttribute]
        public string SoftwareDeveloper { get; set; }
        [XmlAttribute]
        public string Version { get; set; }
        [XmlAttribute]
        public string GUID { get; set; }
        public Software()
        {

        }
        public Software(string softwareDeveloper, string version, string guid)
        {
            SoftwareDeveloper = softwareDeveloper;
            Version = version;
            GUID = guid;
        }
        public Software(string softwareDeveloper,string guid)
        {
            SoftwareDeveloper = softwareDeveloper;
            GUID = guid;
        }
    }
    
}
