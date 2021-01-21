using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings
{
    class Record
    {
        //Properties
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int YearReleased { get; set; }
        public bool IsAwesome = true;

        public Record(string artistName, string albumName, int yearReleased, bool isAwesome)
        {
            ArtistName = artistName;
            AlbumName = albumName;
            YearReleased = yearReleased;
            IsAwesome = isAwesome;
            if (isAwesome == true)
            {
                Console.WriteLine($"This {artistName} record is awesome!");
            }
            else
            {
                Console.WriteLine($"This {artistName} record sucks!");
            }
        }

        //Methods
        public void Format(string format)
        {
            Console.WriteLine($"I mostly enjoy listening to music on {format}");
        }

    }
}
