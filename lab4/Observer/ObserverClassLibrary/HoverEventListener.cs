using ObserverClassLib.LightHTML;

namespace ObserverClassLibrary
{
    public class HoverEventListener : IEventListener
    {
        public string eventName { get; }

        public HoverEventListener()
        {
            eventName = "hover";
        }

        public void Action(LightElementNode eventTarget)
        {
            Console.WriteLine($"Hover event triggered on {eventTarget.TagName}");
        }
    }
}