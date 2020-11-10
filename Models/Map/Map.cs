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
using System.Linq;

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
        public List<Button> buttons { get; set; }

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

            List<Point> shipCoordinates = new List<Point>();
            int n = Math.Max(newShip.XOffset, newShip.YOffset);

            int x = newShip.X;
            int y = newShip.Y;
            for (int i = 0; i < n; i++)
            {
                if (newShip.horizontal)
                {
                    shipCoordinates.Add(new Point(x++, y));
                }
                else
                {
                    shipCoordinates.Add(new Point(x, y++));
                }

                if (shipCoordinates[i].X > MapSizeX || shipCoordinates[i].Y > MapSizeY || shipCoordinates[i].X < 0 || shipCoordinates[i].Y < 0)
                {
                    return "Ship out of map boundaries";
                }
            }


            Ship ship = null;
            var shipGroupEnum = ShipGroups.GetEnumerator();
            while (shipGroupEnum.MoveNext())
            {
                var shipsEnum = shipGroupEnum.Current.Ships.GetEnumerator();
                while (shipsEnum.MoveNext())
                {
                    Ship current = shipsEnum.Current;
                    foreach (var button in current.buttons)
                    {
                        foreach (var newShipButton in shipCoordinates)
                        {
                            if (getButtonCoordinates(button).Equals(newShipButton) && newShip.Id != current.Id)
                            {
                                return "Cannot place ship on another ship";
                            }
                        }
                    }
                }
            }

            return null;
        }
        public string ValidateCoordinatesInitial(Ship newShip)
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
                    if (current.HP < 0) { current.HP = 0; } // Tikslas: Nesusidurti su neigiamu skaiciumi
                    current.ParseShipResponse(shipsResponseEnum.Current);

                    IShip current_decor = new Named(current);
                    //MessageBox.Show(current.HP.ToString() + "  Previous: " + current.PreviousHP);


                    if (current.isDamaged())
                    {
                        if (current.isDead())
                        {
                            current_decor = new Dead(current_decor);
                            if (current.DeadDamaged())
                            {
                                visualization.draw(current.buttons, new Damaged(current_decor));
                            }
                            else
                            {
                                visualization.draw(current.buttons, current_decor);
                            }
                        }
                        else
                        {
                            current_decor = new Damaged(current_decor);
                            visualization.draw(current.buttons, current_decor);
                        }
                    }
                    if (current.HasBeenShot())
                    {
                        ship = current;
                        if (!ship.isDead())
                        {
                            ship.Shot();
                            current.Shot();
                        }
                    }
                }
            }

            return ship;
        }

        public Ship getShipByCoordinates(int xCord, int yCord)
        {
            Point point = new Point(xCord, yCord);
            Ship ship = null;
            var shipGroupEnum = ShipGroups.GetEnumerator();
            while (shipGroupEnum.MoveNext())
            {
                var shipsEnum = shipGroupEnum.Current.Ships.GetEnumerator();
                while (shipsEnum.MoveNext())
                {
                    Ship current = shipsEnum.Current;
                    foreach (var button in current.buttons)
                    {
                        if (getButtonCoordinates(button).Equals(point))
                        {
                            ship = current;
                        }
                    }
                }
            }
            return ship;
        }
        public Point getButtonCoordinates(Button button)
        {
            string text = button.Name.ToString();
            int xCord;
            if (!text.Last().Equals('0'))
                xCord = Convert.ToInt32(text.Last().ToString()) - 1;
            else
                xCord = 9;

            int yCord = Array.IndexOf(new char[]{ 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' }, text[0]);

            return new Point(xCord, yCord);
        }

        public bool IsSubmarine(Ship ship)
        {
            var shipGroupEnum = ShipGroups.GetEnumerator();
            while (shipGroupEnum.MoveNext())
            {
                ShipGroup shipGroup = shipGroupEnum.Current;
                var shipsEnum = shipGroup.Ships.GetEnumerator();
                while (shipsEnum.MoveNext())
                {
                    Ship current = shipsEnum.Current;
                    if (current.Id == ship.Id)
                    {
                        return shipGroup.ShipType.IsSubmarine;
                    }
                    
                }
            }
            return false;
        }
    }
}
