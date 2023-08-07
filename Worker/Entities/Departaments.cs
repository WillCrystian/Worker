using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Entities
{
    internal class Departaments
    {
        public string Name { get; set; }

        public Departaments() { }
        public Departaments(string name)
        {
            Name = name;
        }
    }
}
