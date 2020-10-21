using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models
{
    public class Room
    {
        public string Id { get; set; }
        public int Size { get; set; }
        public bool IsHostTurn { get; set; }
        public string WinnerId { get; set; }

        public ICollection<Map> Maps { get; set; }
    }
}
