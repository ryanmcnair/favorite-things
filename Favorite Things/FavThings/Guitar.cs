using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings
{
    class Guitar
    {
        //Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private bool _changeStrings = true;
        //Constructor
        public Guitar(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Console.WriteLine($"Enjoy your new {Year} {Brand} {Model}");
        }
        //Methods
        public void CleanUp(string model)
        {
            if (_changeStrings)
            {
                Console.WriteLine($"Time to change the strings on your {model}");
                _changeStrings = false;
            }
            else
            {
                Console.WriteLine($"Your {model} is ready to rock");

            }
        }
        public void Acoustic(string model)
        {
            Console.WriteLine($"That is a lovely {model}");
        }
    }
}
