﻿using System;
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
        private string soort;

        public Plant(string _naam, int _water, string _soort)
        {
            naam = _naam;
            water = _water;
            soort = _soort;
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Water
        {
            get { return water; }
        }

        public string Soort
        {
            get { return soort; }
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
