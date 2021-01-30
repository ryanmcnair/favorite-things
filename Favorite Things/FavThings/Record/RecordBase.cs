using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Record
{
    class RecordBase
    {
        //Properties
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int YearReleased { get; set; }
        public bool IsAwesome { get; set; }

        public RecordBase()
        {
            
        }

        //Methods

        public void Awesome()
        {
            if (IsAwesome == true)
            {
                Console.WriteLine($"This {ArtistName} record {AlbumName} is awesome!");
            }
            else
            {
                Console.WriteLine($"This {ArtistName} record {AlbumName} sucks!");
            }
        }
        public void Format(string format)
        {
            Console.WriteLine($"I mostly enjoy listening to music on {format}");
        }

    }
}
