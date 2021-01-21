using System;
using Favorite_Things.FavThings;

namespace Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar lesPaul = new Guitar("Gibson", "Les Paul", 1979);
            Guitar strat = new Guitar("Fender", "Stratocaster", 1985);
            lesPaul.CleanUp("Les Paul");
            lesPaul.CleanUp("Les Paul");
            strat.Acoustic("Martin");
            Console.WriteLine();
            Record gratefulDead = new Record("Grateful Dead", "Wake of the Flood", 1973, true);
            Record nickleback = new Record("Nickleback", "Silver Side Up", 2005, false);
            Console.WriteLine();
            Show bsg = new Show("Battlestar Galactica", "Sci-Fi", "Hulu", 2004);
            Show sopranos = new Show("Sopranos", "Drama", "HBO", 1999);
            bsg.IsScary("Lovecraft Country", "horror");
            Console.WriteLine();
            Beer budLight = new Beer("Bud Light", "Cheap beer", false);
            Beer yazoo = new Beer("Yazoo", "Lager", true);
            yazoo.Yummy(true);
            budLight.Yummy(false);
            

        }
    }
}
