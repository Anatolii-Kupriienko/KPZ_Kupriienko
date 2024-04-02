using AbstractFactoryClassLib.Interfaces;
using ProductsClassLib.Implementations;
using ProductsClassLib.Interfaces;

namespace AbstractFactoryClassLib.Implementations
{
    public class YeskiaFactory : IAbstractFactory
    {
        public IEBook CreateEbook()
        {
            return new YeskiaEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new YeskiaLaptop();
        }

        public ISmartphone CreateSmartphone()
        {
            return new YeskiaSmartphone();
        }
    }
}