using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsClassLib.Interfaces
{
    public interface IDevice
    {
        bool isOn { get; set; }
        void Boot();
        void Shutdown();
    }
}