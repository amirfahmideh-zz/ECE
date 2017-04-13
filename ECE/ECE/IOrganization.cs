using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE
{
    interface IOrganization
    {
        string Organization { get; set; }
        string Department { get; set; }
        string Position { get; set; }
        string Name { get; set; }
        string Code { get; set; }
    }
}
