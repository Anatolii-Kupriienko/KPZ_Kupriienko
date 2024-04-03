using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderClassLib
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetClass(string charClass);
        ICharacterBuilder SetNickname(string nickname);
        ICharacterBuilder SetLevel(int level);
        ICharacterBuilder SetHealth(int health);
        Character Build();
    }
}