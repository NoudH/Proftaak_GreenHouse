using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Greenhouse
{
    class Plant
    {
        private string naam;
        private int water;

        public Plant(string _naam, int _water)
        {
            naam = _naam;
            water = _water;
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Water
        {
            get { return water; }
        }
    }
}
