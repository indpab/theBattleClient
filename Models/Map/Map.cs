using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Weapons;
using TheBattleShipClient.Models.Ships;
using System.Windows.Forms;
using System.Drawing;

namespace TheBattleShipClient.Models
{
    public class Map
    {

        protected string _token;
        protected string _roomId;
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public bool IsCompleted { get; set; }
        public int? EnemyShot_X { get; set; }
        public int? EnemyShot_Y { get; set; }

        public int MapSizeX { get; private set; }
        public int MapSizeY { get; private set; }
        List<Button> buttons { get; set; }

        public Map(string token, string roomId, int mapSizeX, int mapSizeY, List<Button> buttons)
        {
            _token = token;
            _roomId = roomId;
            MapSizeX = mapSizeX;
            MapSizeY = mapSizeY;
            this.buttons = buttons;
        }

        public ICollection<ShipGroup> ShipGroups { get; set; }
        public ICollection<Weapon> Weapons { get; set; }

        public string ValidateCoordinates(Ship newShip)
        {

            int index = newShip.X + newShip.Y * MapSizeX; ;
            if (newShip.horizontal)
            {
                if (newShip.HP + newShip.X > MapSizeX)
                {
                    return "Ship out of map boundaries";
                }
                for (int i = 0; i < newShip.HP; i++)
                {
                    if (buttons[index++].BackColor != Color.White)
                    {
                        return "Cannot place ship on another ship";
                    }
                }
            }
            else
            {
                if (newShip.HP + newShip.Y > MapSizeY)
                {
                    return "Ship out of map boundaries";
                }
                for (int i = 0; i < newShip.HP; i++)
                {
                    if (buttons[index].BackColor != Color.White)
                    {
                        return "Cannot place ship on another ship";
                    }
                    index += MapSizeX;
                }
            }
            return null;
        }
    }
}
