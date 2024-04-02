using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public interface IPrototype
    {
        double Weight { get; set; }
        int Age { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        List<IPrototype> Children { get; set; }
        IPrototype CLone(bool deep = false);
    }
}