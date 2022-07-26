using System.Collections.Generic;
using UnityEngine;

namespace Garra.SSGE
{
    public abstract class GameEventBase<TAction> : ScriptableObject, IGameEvent<TAction>
    {
        protected List<TAction> _listeners = new List<TAction>();

        public void AddEventListener(TAction listener)
        {
            if (!_listeners.Contains(listener))
            {
                _listeners.Add(listener);
            }
        }

        public void RemoveEventListener(TAction listener)
        {
            if (_listeners.Contains(listener))
            {
                _listeners.Remove(listener);
            }
        }
    }
}