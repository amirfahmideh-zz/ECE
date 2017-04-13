using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Priority
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Code { get; set; }
        public Priority()
        {

        }
        public Priority(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
