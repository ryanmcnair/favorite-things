using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Guitar
{
    class GretschWhiteFalcon: GuitarBase
    {
        public bool IsHollowbody { get; set; }

        public GretschWhiteFalcon()
        {
            Brand = "Gretsch";
            Model = "White Falcon";
            Year = 1965;
            IsHollowbody = true;
        }
    }
}
