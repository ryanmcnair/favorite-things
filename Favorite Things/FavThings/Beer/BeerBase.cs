using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Beer
{
    class BeerBase
    {
        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsDelicious { get; set; }
        public bool BrewedLocally { get; set; }
        //Constructor
        public BeerBase()
        {
            Name = "Beer";
            Type = "Beer";
        }


        //Methods
        public void Yummy(bool isDelicious)
        {
            if(isDelicious)
            {
                Console.WriteLine($"This {Name} beer is delicious");
            }
            else
            {
                Console.WriteLine($"{Name}, not good");
            }

        }
    }
}
