namespace Garra.SSGE
{
    public interface IGameEvent<TAction>
    {
        void AddEventListener(TAction listener);
        void RemoveEventListener(TAction listener);
    }
}