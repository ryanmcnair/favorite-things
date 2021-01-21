using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings
{
    class Show
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Service { get; set; }
        public int YearReleased { get; set; }
        //Constructor
        public Show(string name, string genre, string service, int yearReleased)
        {
            Name = name;
            Genre = genre;
            Service = service;
            YearReleased = yearReleased;
            if (yearReleased < 2000)
            {
                Console.WriteLine($"Dang! {name}, from {yearReleased} is old");
            }
            else
            {
                Console.WriteLine($"Enjoy {name} from {yearReleased}");
            }
        }
        //Methods
       
        public void IsScary(string name, string genre)
        {
            if (genre == "horror" || genre == "Horror")
            {
                Console.WriteLine($"You better sleep with the lights on, I heard {name} is scary");
            }
        }
    }
}
