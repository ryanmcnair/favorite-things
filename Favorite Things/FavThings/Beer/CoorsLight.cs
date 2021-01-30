using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Beer
{
    class CoorsLight : BeerBase
    {
        public bool FromTheRockies { get; set; }

        public CoorsLight()
        {
            Name = "Coors Light";
            Type = "Lager";
            IsDelicious = false;
            BrewedLocally = false;
            FromTheRockies = true;
        }
    }
}
