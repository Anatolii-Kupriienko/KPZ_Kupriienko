
using CompositeClassLib;

var list = new LightElementNode("ul", TagTypes.Block, false, new List<string>());

for (int i = 0; i < 5; i++)
{
    var item = new LightElementNode("li", TagTypes.Block, false, new List<string>());
    item.Add(new LightTextNode("Item " + i));
    list.Add(item);
}

list.Display();