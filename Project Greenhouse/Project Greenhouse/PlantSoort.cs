using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Greenhouse
{
    class PlantSoort
    {
        private string naam;

        public PlantSoort(string _naam)
        {
            naam = _naam;
        }

        public string Naam
        {
            get { return naam; }
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
