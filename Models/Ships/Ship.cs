using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.ShipsService;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public abstract class Ship : Decorator.IShip, ICloneable
    {
        public int Id { get; protected set; }
        public int X { get; set; }
        public int XOffset { get; set; }
        public int Y { get; set; }
        public int YOffset { get; set; }
        public bool horizontal { get; set; }
        public double HP { get; set; }
        public double PreviousHP { get; set; }
        protected double InitialHP { get; set; }

        public List<Button> buttons { get; set; }
        
        protected string _token;
        protected string _roomId;

        private IMotionAlgorithm _motionAlgoritm = new MoveStraightSlowAlgorithm();

        public Ship(string token, string roomId, int x, int y, bool horizontal, int hp)
        {
            _token = token;
            _roomId = roomId;

            this.X = x;
            this.Y = y;
            this.horizontal = horizontal;
            this.HP = hp;
            this.PreviousHP = hp;
            this.InitialHP = hp;
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

        public void InitializeButtons()
        {
            this.buttons = new List<Button>();
        }
        public void SetMotionAlgoritm(IMotionAlgorithm algorithm)
        {
            _motionAlgoritm = algorithm;
        }

        public void Move()
        {
            _motionAlgoritm.Move(this);
            
        }

        public async Task Update()
        {

            var shipResponse = await Service.UpdateShip(_token, this.Id, X, XOffset, Y, YOffset, 0);
            this.HP = shipResponse.HP;
        }

        public abstract Task Create();

        public string getSkin()
        {
            return " "; 
        }

        public Ship ShallowClone()
        {
            return (Ship)this.MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return (Ship)this.MemberwiseClone();
        }
        public Ship DeepClone()
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, this);
            ms.Position = 0;

            return (Ship)formatter.Deserialize(ms);
        }
        public void Rotate(bool horizontal)
        {
            if (horizontal)
            {
                this.XOffset = (int)this.HP;
                this.YOffset = 1;
            }
            else
            {
                this.XOffset = -1;
                this.YOffset = (int)this.HP;
            }
            this.horizontal = horizontal;
        }

        public void setCordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;

            if (horizontal)
            {
                this.XOffset = Convert.ToInt32(this.HP);
                this.YOffset = 1;
            }
            else
            {
                this.XOffset = -1;
                this.YOffset = Convert.ToInt32(this.HP);
            }
        }

        public void ParseShipResponse(ShipResponse shipResponse)
        {
            this.X = shipResponse.X;
            this.Y = shipResponse.Y;
            this.XOffset = shipResponse.XOffset;
            this.YOffset = shipResponse.YOffset;
            this.HP = shipResponse.HP;
            this.Id = shipResponse.Id;
        }
        public bool HasBeenShot()
        {
            return PreviousHP > HP;
        }
        public bool DeadDamaged()
        {
            return PreviousHP != InitialHP;
        }
        public void Shot()
        {
            PreviousHP = HP;
        }
        public bool isDead()
        {
            return HP <= 0;
        }
        public bool isDamaged()
        {
            return HP < InitialHP;
        }
    }
}
