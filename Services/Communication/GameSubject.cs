using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    class GameSubject 
    {
        private List<IGameObserver> _observers;
        public bool SubjectState 
        {
            get { return _subjectState; }
            set 
            {
                _subjectState = value;
                NotifyObservers();
            } 
        }
        private bool _subjectState;

        public GameSubject()
        {
            _observers = new List<IGameObserver>();
            SubjectState = false;
        }

        public void Attach(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unattach(IGameObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IGameObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
