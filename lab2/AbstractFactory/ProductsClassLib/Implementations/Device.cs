using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class Device : IDevice
    {
        public bool isOn { get; set; }

        public void Boot()
        {
            if (isOn)
            {
                Console.WriteLine("Device is already on");
                return;
            }
            isOn = true;
            Console.WriteLine("Booting device...");
        }

        public void Shutdown()
        {
            if (!isOn)
            {
                Console.WriteLine("Device is already off");
                return;
            }
            isOn = false;
            Console.WriteLine("Shutting down device...");
        }
    }
}