using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MementoClassLib
{
    public interface ICaretaker
    {
        void Backup();
        void Undo();
    }
}