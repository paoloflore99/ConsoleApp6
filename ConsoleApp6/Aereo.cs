using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Aereo : Veicolo , IVolo
    {

        public int NumeroMotori {  get; set; }
        public int CapienzaPasseggeri  {  get; set; }

        
        public void Vola()
        {
            Console.WriteLine("vola volavolavola");
        }

    }
}
