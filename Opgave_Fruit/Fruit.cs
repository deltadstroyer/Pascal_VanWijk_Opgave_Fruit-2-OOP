using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Opgave_Fruit
{
    abstract public class Fruit : IComparable<Fruit>
    {
        public string Naam { get; set; }
        public double PrijsPerKg { get; set; }

        public Fruit(string naam, double prijsPerKg)
        {
            Naam = naam;
            PrijsPerKg = prijsPerKg;
        }


        public int CompareTo([AllowNull] Fruit other)
        {
            if (this.PrijsPerKg > other.PrijsPerKg)
            {
                return 1;
            }
            else if (this.PrijsPerKg < other.PrijsPerKg)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Naam + PrijsPerKg;
        }
    }
}
