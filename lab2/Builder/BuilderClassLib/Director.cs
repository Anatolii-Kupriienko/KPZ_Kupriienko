using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderClassLib
{
    public class Director
    {
        private ICharacterBuilder _builder;
        public ICharacterBuilder Builder
        {
            get { return _builder; }
            set { _builder = value; }
        }
        public Director(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void Create(string name, string charClass, string nickname, int level, int health)
        {
            _builder.SetName(name)
                .SetClass(charClass)
                .SetNickname(nickname)
                .SetLevel(level)
                .SetHealth(health);
        }
    }
}