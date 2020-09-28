using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class Ship
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double HP { get; set; }
        public bool IsHorizontal { get; set; }
    }
}
