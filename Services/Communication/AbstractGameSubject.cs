using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    public abstract class AbstractGameSubject
    {
        private List<IGameObserver> _observers = new List<IGameObserver>();

        public void Attach(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IGameObserver observer)
        {
            _observers.Remove(observer);
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
