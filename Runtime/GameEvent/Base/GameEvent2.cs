using System;

namespace Garra.SSGE
{
    public abstract class GameEvent2<T0, T1> : GameEventBase<Action<T0, T1>>
    {
        public void Raise(T0 arg0, T1 arg1)
        {
            for (int i = 0; i < _listeners.Count; i++)
            {
                _listeners[i]?.Invoke(arg0, arg1);
            }
        }
    }
}