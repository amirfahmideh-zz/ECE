using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Classification
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Code { get; set; }
        public Classification()
        {

        }
        public Classification(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
