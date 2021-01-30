using System;
using Favorite_Things.FavThings;
using Favorite_Things.FavThings.Beer;
using Favorite_Things.FavThings.Guitar;
using Favorite_Things.FavThings.Record;
using Favorite_Things.FavThings.Show;


namespace Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var coorsLight = new CoorsLight();
            coorsLight.Yummy(false);
            var fenderTelecaster = new FenderTelecaster();
            fenderTelecaster.Brand = "Fender";
            fenderTelecaster.Model = "Telecaster";
            fenderTelecaster.Year = 2018;
            fenderTelecaster.Acoustic();
            fenderTelecaster.CleanUp();
            var cobraKai = new CobraKai();
            cobraKai.OldShow();
            var handmaidsTale = new HandmaidsTale();
            handmaidsTale.IsScary();
            var neilYoung = new NeilYoung();
            neilYoung.Awesome();
            //GuitarBase lesPaul = new GuitarBase("Gibson", "Les Paul", 1979);
            //GuitarBase strat = new GuitarBase("Fender", "Stratocaster", 1985);
            //strat.Acoustic("Martin");
            //Console.WriteLine();
            //RecordBase gratefulDead = new RecordBase("Grateful Dead", "Wake of the Flood", 1973, true);
            //RecordBase nickleback = new RecordBase("Nickleback", "Silver Side Up", 2005, false);
            //Console.WriteLine();
            //ShowBase bsg = new ShowBase("Battlestar Galactica", "Sci-Fi", "Hulu", 2004);
            //ShowBase sopranos = new ShowBase("Sopranos", "Drama", "HBO", 1999);
            //bsg.IsScary("Lovecraft Country", "horror");
            //Console.WriteLine();
            //BeerBase budLight = new BeerBase("Bud Light", "Cheap beer", false);
            //BeerBase yazoo = new BeerBase("Yazoo", "Lager", true);
            //yazoo.Yummy(true);
            //budLight.Yummy(false);
            

        }
    }
}
