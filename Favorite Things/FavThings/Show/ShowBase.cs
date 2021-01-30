using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Show
{
    class ShowBase
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Service { get; set; }
        public int YearReleased { get; set; }
        //Constructor
        public ShowBase()
        {
            
        }
        //Methods

        public void OldShow()
        {
            if (YearReleased < 2019)
            {
                Console.WriteLine($"Dang! {Name}, from {YearReleased} is old");
            }
            else
            {
                Console.WriteLine($"Enjoy {Name} from {YearReleased}");
            }
        }
       
        public void IsScary()
        {
            if (Genre.Contains("horror"))
            {
                Console.WriteLine($"You better sleep with the lights on, I heard {Name} is scary");
            }
        }
    }
}
