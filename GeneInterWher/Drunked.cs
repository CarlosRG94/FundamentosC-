using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneInterWher
{
    public class Drunked : IPerson
    {
        public string Name { get; set ; }
        public bool Alive { get ; set; }
        public int Alcohol { get; set; }    
        public Drunked()
        {
            Alive = true;
        }
    }
    
}
