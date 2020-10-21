using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    class GameSubject : IGameSubject
    {
        private List<IGameObserver> _observers;
        public bool JoinedState 
        {
            get { return _joinedState; }
            set 
            {
                _joinedState = value;
                NotifyObservers();
            } 
        }
        private bool _joinedState;
        public bool PlayerState
        {
            get { return _playerState; }
            set
            {
                _playerState = value;
                NotifyObservers();
            }
        }
        private bool _playerState;

        public GameSubject()
        {
            _observers = new List<IGameObserver>();
            JoinedState = false;
            PlayerState = false;
        }

        public void Attach(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        /*
        public void Unattach(IGameObserver observer)
        {
            _observers.Remove(observer);
        }
        */

        public async void StartObserving(string token, string roomId)
        {
            bool stateChanged = false;
            while (stateChanged == false)
            {

                bool isGuestUserJoinedIn = await RoomsService.IsGuestUserJoined(token, roomId);
                if (isGuestUserJoinedIn != JoinedState)
                {
                    stateChanged = true;
                    JoinedState = isGuestUserJoinedIn;
                }
            }
        }
        public async void StartObservingGame(string token, string roomId)
        {
            bool isMyTurn = await MapsService.IsMyTurn(token, roomId);
            if (isMyTurn != PlayerState)
            {
                PlayerState = isMyTurn;
            }
        }

        public void NotifyObservers()
        {
            foreach (IGameObserver observer in _observers)
            {
                observer.UpdateState();
            }
        }
    }
}
