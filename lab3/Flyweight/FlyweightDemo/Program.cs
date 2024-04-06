using System.Diagnostics;
using CompositeClassLib;
using FlyweightClassLib;

//it looks like I implemented it correctly but it doesn't really work
//as in it doesn't save memory
UsingComposite();
UsingFlyweigth();
//after some testing can add that it does save memory if we use LightTextNode instead of LightNode in the ContextElementNode class

static void UsingComposite()
{
    var bookContent = File.ReadAllLines("book.txt");

    var h1 = new LightElementNode("h1", TagTypes.Block, false, new List<string>());
    h1.Add(new LightTextNode(bookContent[0]));
    LightElementNode[] result = new LightElementNode[bookContent.Length];
    result[0] = h1;
    for (int i = 1; i < bookContent.Length; i++)
    {
        var line = bookContent[i];
        LightElementNode node;
        if (line.Length < 20)
        {
            node = new LightElementNode("h2", TagTypes.Block, false, new List<string>());
            node.Add(new LightTextNode(line));
        }
        else if (line.StartsWith(" "))
        {
            node = new LightElementNode("blockquote", TagTypes.Block, false, new List<string>());
            node.Add(new LightTextNode(line));
        }
        else
        {
            node = new LightElementNode("p", TagTypes.Block, false, new List<string>());
            node.Add(new LightTextNode(line));
        }
        result[i] = node;
    }
    // foreach (var node in result)
    // {
    //     node.Display();
    // }
    var size = Process.GetCurrentProcess().WorkingSet64 / 1_000_000.0;
    Console.WriteLine($"Using composite classes process physical memory size: {size} MB of which approximately {size - 17.6} MB is by the programm");
}

static void UsingFlyweigth()
{
    var bookContent = File.ReadAllLines("book.txt");
    var newH1 = FlyweightLightElementNodeFactory.GetNode("h1");
    ContextElementNode contextH1 = new ContextElementNode(newH1);
    contextH1.Add(new LightTextNode(bookContent[0]));
    // contextH1.Add(bookContent[0]);

    ContextElementNode[] newResult = new ContextElementNode[bookContent.Length];
    newResult[0] = contextH1;

    for (int i = 1; i < bookContent.Length; i++)
    {
        var line = bookContent[i];
        FlyweightLightElementNode node;
        if (line.Length < 20)
        {
            node = FlyweightLightElementNodeFactory.GetNode("h2");
        }
        else if (line.StartsWith(" "))
        {
            node = FlyweightLightElementNodeFactory.GetNode("blockquote");
        }
        else
        {
            node = FlyweightLightElementNodeFactory.GetNode("p");
        }
        var contextNode = new ContextElementNode(node);
        contextNode.Add(new LightTextNode(line));
        // contextNode.Add(line);
        newResult[i] = contextNode;
    }

    // foreach (var node in newResult)
    // {
    //     node.Display();
    // }

    var size = Process.GetCurrentProcess().WorkingSet64 / 1_000_000.0;
    Console.WriteLine("Count of objects in the factory = " + FlyweightLightElementNodeFactory.GetCountOfNodes());
    Console.WriteLine($"Using composite classes process physical memory size: {size} MB of which approximately {size - 17.6} MB is by the programm");
}