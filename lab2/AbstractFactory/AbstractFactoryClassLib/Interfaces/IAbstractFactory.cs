using ProductsClassLib.Interfaces;

namespace AbstractFactoryClassLib.Interfaces
{
    public interface IAbstractFactory
    {
        ILaptop CreateLaptop();
        ISmartphone CreateSmartphone();
        IEBook CreateEbook();
    }
}