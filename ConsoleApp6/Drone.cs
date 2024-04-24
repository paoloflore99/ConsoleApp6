using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Drone : IVolo
    {
        public int Autonomia { get; set; }
        public void Vola()
        {
            Console.WriteLine("zzzz");
        }
    }
}
