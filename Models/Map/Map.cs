using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Weapons;
using TheBattleShipClient.Models.Ships;

namespace TheBattleShipClient.Models
{
    public class Map
    {
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public bool IsCompleted { get; set; }
        public int? EnemyShot_X { get; set; }
        public int? EnemyShot_Y { get; set; }


        public Room Room { get; set; }

        public ICollection<ShipGroup> ShipGroups { get; set; }
        public ICollection<Weapon> Weapons { get; set; }
    }
}
