using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE
{
    public class RelationType
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public RelationType()
        {

        }
        public RelationType(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
    
}
