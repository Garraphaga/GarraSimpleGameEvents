using System;

namespace Garra.SSGE
{
    public abstract class GameEvent : GameEventBase<Action>
    {
        public void Raise()
        {
            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i]?.Invoke();
            }
        }
    }
}