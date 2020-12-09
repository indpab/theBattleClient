using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Models.Ships.Command;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.ShipsService;
using TheBattleShipClient.Models.Ships.Composite;
using TheBattleShipClient.Models.Ships.Iterator;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public abstract class Ship : Decorator.IShip, ICloneable, Aggregate
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

        public ButtonComponent button { get; set; }
        public List<Button> buttons { get { return GetButtons(); } }
        private IMotionAlgorithm _motionAlgoritm = new MoveStraightSlowAlgorithm();
        private IMotionState _motionState = new MoveStraightSlowState();

        protected string _token;
        protected string _roomId;

        //private IMotionState _motionState = new MoveStraightSlowState();


        private Command.ShipCommand _Command;

        protected string skinText = "Ship";

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
            this.button = null;
        }
        public void AddButtons(ButtonComponent button)
        {
            this.button = button;
        }
        public void SetMotionAlgoritm(IMotionAlgorithm algorithm)
        {
            _motionAlgoritm = algorithm;   
        }

        public void SetMotionState(IMotionState state)

        {
            _motionState = state;
        }

        public async Task Move()
        {

            await _motionAlgoritm.Move(this);
            

            //_motionState.Move(this);
            //await Update();

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

        public ShipSnapshotMemento GetSnapshot()
        {
            return new ShipSnapshotMemento(new ShipSnapshot
            {
                X = this.X,
                Y = this.Y,
                XOffset = this.XOffset,
                YOffset = this.YOffset
            });
        }

        public void SetSnapshot(ShipSnapshotMemento snapshot)
        {
            var shipSnapshot = snapshot.GetSnapshot();
            this.X = shipSnapshot.X;
            this.Y = shipSnapshot.Y;
            this.XOffset = shipSnapshot.XOffset;
            this.YOffset = shipSnapshot.YOffset;

        }

        public Iterator.Iterator CreateIterator()
        {
            return new ShipButtonIterator(this);
        }
        public bool ContainsButton(Button button)
        {
            ShipButtonIterator shipButtons = (ShipButtonIterator)CreateIterator();
            while (shipButtons.MoveNext())
            {
                if (shipButtons.Current().Equals(button))
                {
                    return true;
                }
            }
            return false;
        }
        public void UpdateShipButtons()
        {
            ShipButtonIterator shipButtons = (ShipButtonIterator)CreateIterator();
            while (shipButtons.MoveNext())
            {
                ((ButtonComponent)shipButtons.Current()).UpdateButton();
            }
        }
        public List<Button> GetButtons()
        {
            ShipButtonIterator shipButtons = (ShipButtonIterator)CreateIterator();
            return shipButtons.GetAsList();
        }
    }
}
