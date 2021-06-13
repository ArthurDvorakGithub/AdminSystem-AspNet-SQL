using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGameNetCore.Models
{
    public class Tile
    {
        public Tile(string tileURL, string tileName)
        {
            TileURL = tileURL;
            TileName = tileName;
        }

        public int Id { get; set; }
        public string TileURL { get; set; }
        public string TileName { get; set; }

        
    }
}
