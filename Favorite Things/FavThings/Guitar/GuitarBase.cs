using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Guitar
{
    class GuitarBase
    {
        //Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private bool _changeStrings = true;
        //Constructor
        public GuitarBase()
        {
            
        }
        //Methods
        public void CleanUp()
        {
            if (_changeStrings)
            {
                Console.WriteLine($"Time to change the strings on your {Model}");
                _changeStrings = false;
            }
            else
            {
                Console.WriteLine($"Your {Model} is ready to rock");

            }
        }
        public void Acoustic()
        {
            Console.WriteLine($"That is a lovely {Model}");
        }
    }
}
