using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons
{
    public abstract class Weapon
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsSuccessful { get; set; }
        public List<int> ShipTypes { get; set; }
    }
}
