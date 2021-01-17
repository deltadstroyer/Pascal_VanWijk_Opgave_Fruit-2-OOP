using System;
using System.Text;
using System.Threading;
namespace Opgave_Fruit
{
    class Program
    {
        private static Fruit[] fruitsoorten;
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("nl-BE");
            Thread.CurrentThread.CurrentCulture = culture;
            Console.OutputEncoding = Encoding.Unicode;
            InitFruitSoorten();
            FruitLijst fruitLijst = new FruitLijst();
            foreach (Fruit fruit in fruitsoorten)
            {
                fruitLijst.Add(fruit);
            }
            fruitLijst.SorteerVolgensPrijs();
            fruitLijst.Toon();
            Console.ReadKey();
        }
        private static void InitFruitSoorten()
        {
            fruitsoorten = new Fruit[]{
            new Citroen("Algarve", 3.0),
            new Sinaasappel("Jaffa", 3.2, true),
            new Sinaasappel("Bloedappelsien", 3.4, true),
            new Pompelmoes("Roze pompelmoes", 3.1, "roze"),
            new Sinaasappel("Persappelsien", 2.5, false),
            new Pompelmoes("Rode pompelmoes", 3.3, "rood"),
            new Pompelmoes("Witte pompelmoes", 2.9, "wit"),
            };
        }
    }
}