using ObserverClassLibrary;
using ObserverClassLib.LightHTML;

LightElementNode div = new LightElementNode("div", TagTypes.Block, false, new List<string>());

div.TriggerEvent("click");
div.TriggerEvent("hover");

ClickEventListener clickListener = new ClickEventListener();
div.AddEvent(clickListener);

div.TriggerEvent("click");
div.TriggerEvent("hover");

HoverEventListener hoverListener = new HoverEventListener();
div.AddEvent(hoverListener); 

div.TriggerEvent("click");
div.TriggerEvent("hover");
