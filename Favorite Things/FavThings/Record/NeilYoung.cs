using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.FavThings.Record
{
    class NeilYoung : RecordBase
    {
        public bool IsCanadian { get; set; }

        public NeilYoung()
        {
            ArtistName = "Neil Young";
            AlbumName = "Harvest";
            YearReleased = 1972;
            IsAwesome = true;
            IsCanadian = true;
        }
    }
}
