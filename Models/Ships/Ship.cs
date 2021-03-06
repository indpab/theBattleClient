﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Models.Ships.Command;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.ShipsService;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Ship : Decorator.IShip, ICloneable
    {
        public int Id { get; protected set; }
        public int X { get; set; }
        public int XOffset { get; set; }
        public int Y { get; set; }
        public int YOffset { get; set; }
        public bool horizontal { get; set; }
        public double HP { get; set; }
        
        protected string _token;
        protected string _roomId;

        private IMotionState _motionState = new MoveStraightSlowState();

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

        public void SetMotionState(IMotionState state)
        {
            _motionState = state;
        }

        public async Task Move()
        {
            _motionState.Move(this);
            await Update();
        }

        public async Task Update()
        {
            var shipResponse = await Service.UpdateShip(_token, this.Id, X, XOffset, Y, YOffset, 0);
            this.HP = shipResponse.HP;
        }

        public abstract Task Create();

        public string getSkin()
        {
            return "Ship "; 
        }

        object ICloneable.Clone()
        {
            return (Ship)this.MemberwiseClone();
        }
        protected Ship DeepClone(Ship obj)
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
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
    }
}
