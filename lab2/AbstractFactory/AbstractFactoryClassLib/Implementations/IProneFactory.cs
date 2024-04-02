using AbstractFactoryClassLib.Interfaces;
using ProductsClassLib.Implementations;
using ProductsClassLib.Interfaces;

namespace AbstractFactoryClassLib.Implementations
{
    public class IProneFactory : IAbstractFactory
    {
        public IEBook CreateEbook()
        {
            return new IProneEbook();
        }

        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}