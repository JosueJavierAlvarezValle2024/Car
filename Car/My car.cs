using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class My_car
    {
        // PROPERTIES
        public string _Brand;
        public string _Colour;
        public int _Model;

        // METHODS
        public My_car(string brand, string colour, int model) 
        {
            this._Brand = brand;
            this._Colour = colour;
            this._Model = model;
        }

    }
}
