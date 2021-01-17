using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_Fruit
{
    public class Sinaasappel : Fruit
    {
        private bool _soort { get; set; }

        public Sinaasappel(string naam, double prijsPerKg, bool soort) : base(naam, prijsPerKg)
        {
            _soort = soort;
        }

        public override string ToString()
        {

            if (_soort == true)
            {
                return Naam + "eetappelsien";
            }
            else
            {
                return Naam + "persappelsien";
            }

        }


    }
}
