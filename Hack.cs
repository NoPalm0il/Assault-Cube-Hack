using System;
using System.Collections.Generic;
using System.Text;

namespace Assault_Cube_Hack
{
    class Hack
    {
        public string Name { get; }
        public bool isActive { get; set; }

        public Hack(string Name)
        {
            this.Name = Name;
            isActive = false;
        }
    }
}
