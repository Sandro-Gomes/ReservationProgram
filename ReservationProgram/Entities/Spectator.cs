using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProgram.Entities
{
    internal class Spectator
    {
        public string Name { get; set; }

        public Spectator(string name)
        {
            Name = name;
        }
    }
}
