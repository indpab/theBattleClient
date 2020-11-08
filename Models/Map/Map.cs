using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Weapons;
using TheBattleShipClient.Models.Ships;
using System.Windows.Forms;
using System.Drawing;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.MapsService;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Decorator;
using TheBattleShipClient.Models.Ships.Bridge;

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

        public List<Ship> GetShips()
        {
            List<Ship> theShips = new List<Ship>();
            foreach (var shipGroup in ShipGroups)
            {
                foreach (var ship in shipGroup.Ships)
                {
                    theShips.Add(ship);
                }
            }
            return theShips;
        }

        public void StartGameMap()
        {
            var shipGroupEnum = ShipGroups.GetEnumerator();
            while (shipGroupEnum.MoveNext())
            {
                ShipGroup shipGroup = shipGroupEnum.Current;
                var shipsEnum = shipGroup.Ships.GetEnumerator();
                while (shipsEnum.MoveNext())
                {
                    Ship ship = shipsEnum.Current;
                    ship.Create();
                }
            }
        }

        public async Task<Ship> UpdateMap(Visualization visualization)
        {
            Ship ship = null;
            MapResponse mapResponse = await MapsService.GetMap(_token, _roomId);
            EnemyShot_X = mapResponse.EnemyShot_X;
            EnemyShot_Y = mapResponse.EnemyShot_Y;
            this.IsCompleted = mapResponse.IsCompleted;
            var shipGroupEnum = ShipGroups.GetEnumerator();
            var shipGroupResponseEnum = mapResponse.ShipGroups.GetEnumerator();

            while (shipGroupEnum.MoveNext() && shipGroupResponseEnum.MoveNext())
            {
                var shipsEnum = shipGroupEnum.Current.Ships.GetEnumerator();
                var shipsResponseEnum = shipGroupResponseEnum.Current.Ships.GetEnumerator();
                while (shipsEnum.MoveNext() && shipsResponseEnum.MoveNext())
                {
                    Ship current = shipsEnum.Current;
                    visualization.draw(current.buttons, new Named(current));
                    current.ParseShipResponse(shipsResponseEnum.Current);
                    if (current.HasBeenShot())
                    {
                        ship = current;

                        visualization.draw(ship.buttons, new Named(new Damaged(ship)));
                        if (ship.isDead())
                        {
                            visualization.draw(ship.buttons, new Named(new Dead(ship)));
                        }
                        ship.Shot();
                    }
                }
            }

            return ship;
        }
    }
}
