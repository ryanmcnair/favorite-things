using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Guitar
{
    class FenderTelecaster : GuitarBase
    {
        public bool IsAmerican { get; set; }

        public FenderTelecaster()
        {
            Brand = "Fender";
            Model = "Telecaster";
            Year = 2018;
            IsAmerican = true;
            
        }
    }
}
