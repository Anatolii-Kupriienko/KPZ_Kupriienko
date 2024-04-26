using ObserverClassLib.LightHTML;

namespace ObserverClassLibrary
{
    public class ClickEventListener : IEventListener
    {
        public string eventName { get; }

        public ClickEventListener()
        {
            eventName = "click";
        }

        public void Action(LightElementNode eventTarget)
        {
            Console.WriteLine($"Click event triggered on {eventTarget.TagName}");
        }
    }
}