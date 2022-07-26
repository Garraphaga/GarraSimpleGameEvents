using System;

namespace Garra.SSGE
{
    public abstract class GameEvent1<T0> : GameEventBase<Action<T0>>
    {
        public void Raise(T0 arg0)
        {
            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i]?.Invoke(arg0);
            }
        }
    }
}