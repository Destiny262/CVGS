using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Game
    {
        public Game()
        {
        }

        public int gameId { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public string genre { get; set; }
        public string esrb { get; set; }
        public int saleDiscountId { get; set; }

    }
}

