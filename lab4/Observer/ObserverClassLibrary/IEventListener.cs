using ObserverClassLib.LightHTML;

namespace ObserverClassLibrary
{
    public interface IEventListener
    {
        string eventName { get; }
        void Action(LightElementNode eventTarget);
    }
}