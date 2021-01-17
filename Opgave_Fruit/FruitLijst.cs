using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave_Fruit
{
    public class FruitLijst
    {
        private List<Fruit> _fruitobjecten;
        public List<Fruit> Fruitobjecten
        {
            get { return _fruitobjecten; }
            set { _fruitobjecten = value; }
        }

        public FruitLijst()
        {
            Fruitobjecten = new List<Fruit>();
        }

        public List<Fruit> Add(Fruit fruit)
        {
            _fruitobjecten.Add(fruit);
            return null;
        }

        public void SorteerVolgensPrijs()
        {
            _fruitobjecten.Sort();
        }
        public virtual void Toon()
        {
            foreach (Fruit fruit in _fruitobjecten)
            {
                Console.WriteLine($"{fruit.Naam} : \u20AC {fruit.PrijsPerKg:F2} ");
            }

        }

    }
}
