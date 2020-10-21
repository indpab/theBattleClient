using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.ShipsService;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Ship
    {
        public int Id { get; protected set; }
        public int X { get; set; }
        public int XOffset { get; set; }
        public int Y { get; set; }
        public int YOffset { get; set; }
        public double HP { get; protected set; }
        
        protected string _token;
        protected string _roomId;

        private IMotionAlgorithm _motionAlgoritm = new MoveStraightSlowAlgorithm();

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
                this.XOffset = -1;
                this.YOffset = hp;
            }
        }
        protected bool isShipHorisontal()
        {
            return this.X != -1;
        }

        public void SetMotionAlgoritm(IMotionAlgorithm algorithm)
        {
            _motionAlgoritm = algorithm;
        }

        public async Task Move()
        {
            _motionAlgoritm.Move(this);
            await Update();
        }

        public async Task Update()
        {
            var shipRequest = new ShipRequest
            {
                X = this.X,
                XOffset = this.XOffset,
                Y = this.Y,
                YOffset = this.YOffset,
                ShipTypeId = 0
            };
            var shipResponse = await ShipsService.UpdateShip(_token, this.Id, shipRequest);
            this.HP = shipResponse.HP;
        }

        public abstract Task Create();
        public Ship DeepClone()
        {
            AtomicDestroyer new_ad = new AtomicDestroyer(this._token, this._roomId, this.X, this.Y, isShipHorisontal());
            return new_ad;
        }

        public Ship ShallowClone()
        {
            return (AtomicDestroyer)this.MemberwiseClone();
        }

    }
}
