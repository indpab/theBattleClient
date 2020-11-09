using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    public class GameSubject : AbstractGameSubject
    {
        private bool _joinedState;
        public bool JoinedState 
        {
            get { return _joinedState; }
            set 
            {
                _joinedState = value;
                NotifyObservers();
            } 
        }

        private bool _playerState;
        public bool PlayerState
        {
            get { return _playerState; }
            set
            {
                _playerState = value;
                NotifyObservers();
            }
        }
        
        public GameSubject()
        {
            JoinedState = false;
            PlayerState = false;
        }

        public async void StartObserving(string token, string roomId)
        {
            bool stateChanged = false;
            while (stateChanged == false)
            {
                bool guestHasArrived = await Service.HasGuestArrived(token, roomId);
                if (guestHasArrived != JoinedState)
                {
                    stateChanged = true;
                    JoinedState = guestHasArrived;
                }
            }
        }

        public async void StartObservingGame(string token, string roomId)
        {
            bool stateChanged = false;
            while (stateChanged == false)
            {
                stateChanged = true;
                bool isMyTurn = await MapsService.IsMyTurn(token, roomId);
                if (isMyTurn != PlayerState)
                {
                    PlayerState = isMyTurn;
                }
            }

        }
    }
}
