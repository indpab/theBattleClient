using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public abstract class AbstractShipFactory
    {
        protected string _token;
        protected string _roomId;
        protected Submarine submarine_instance;
        protected Destroyer destroyer_instance;

        public AbstractShipFactory(string token, string roomId)
        {
            _token = token;
            _roomId = roomId;

        }

        public abstract Submarine CreateSubmarine(int x, int y, bool horizontal);
        public abstract Destroyer CreateDestroyer(int x, int y, bool horizontal);

    }
}
