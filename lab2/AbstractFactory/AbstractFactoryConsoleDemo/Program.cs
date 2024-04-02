using AbstractFactoryClassLib.Implementations;
using AbstractFactoryClassLib.Interfaces;

var IPronefactory = new IProneFactory();
var Yeskiafactory = new YeskiaFactory();

ClientMethod(IPronefactory);
ClientMethod(Yeskiafactory);



static void ClientMethod(IAbstractFactory factory)
{
    var laptop = factory.CreateLaptop();
    var smartphone = factory.CreateSmartphone();
    var ebook = factory.CreateEbook();

    laptop.Boot();
    laptop.OpenIDE();
    laptop.CloseIDE();
    laptop.Shutdown();

    smartphone.Boot();
    smartphone.Call("555-1234");
    smartphone.HangUp();
    smartphone.Shutdown();

    ebook.Boot();
    ebook.OpenBook("The Art of War");
    ebook.CloseBook();
    ebook.Shutdown();
}