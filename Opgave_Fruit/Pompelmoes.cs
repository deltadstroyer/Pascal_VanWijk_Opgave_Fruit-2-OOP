using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_Fruit
{
    public class Pompelmoes : Fruit
    {
        private string _kleur { get; set; }
        

        public Pompelmoes( string naam, double prijsPerKg, string kleur) :base(naam,prijsPerKg)
        {
            _kleur = kleur;
        }

        public override string ToString()
        {
            return _kleur;
        }
    }
}
