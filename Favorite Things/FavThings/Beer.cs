using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings
{
    class Beer
    {
        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsDelicious = true;
        //Constructor
        public Beer(string name, string type, bool isDelicious)
        {
            Name = name;
            Type = type;
            IsDelicious = isDelicious;
        }


        //Methods
        public void Yummy(bool isDelicious)
        {
            if(isDelicious)
            {
                Console.WriteLine($"This beer is delicious");
            }
            else
            {
                Console.WriteLine("Not good");
            }

        }
    }
}
