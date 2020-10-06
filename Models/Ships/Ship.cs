using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Ship
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int XOffset { get; set; }
        public int Y { get; set; }
        public int YOffset { get; set; }
        public double HP { get; set; }

        public Ship(int x, int y, bool horizontal, int hp)
        {
            this.X = x;
            this.Y = y;
            this.HP = hp;
            if (horizontal)
            {
                this.XOffset = hp;
                this.YOffset = 1;
            }
            else
            {
                this.XOffset = 1;
                this.YOffset = hp;
            }
        }

        public void Move()
        {

        }

        public abstract void Create(string token, string roomId);
    }
}
