using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Ship
    {
        public int Id { get; protected set; }
        public int X { get; private set; }
        public int XOffset { get; private set; }
        public int Y { get; private set; }
        public int YOffset { get; private set; }
        public double HP { get; protected set; }

        protected string _token;
        protected string _roomId;

        public Ship(string token, string roomId, int x, int y, bool horizontal, int hp)
        {
            _token = token;
            _roomId = roomId;

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

        public abstract void Create();
    }
}
