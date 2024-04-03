using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderClassLib
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character() { Type = "Enemy" };
        public Character Build()
        {
            return _character;
        }

        public ICharacterBuilder SetClass(string charClass)
        {
            _character.Class = charClass;
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            _character.Health = health;
            return this;
        }

        public ICharacterBuilder SetLevel(int level)
        {
            _character.Level = level;
            return this;
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetNickname(string nickname)
        {
            _character.Nickname = nickname;
            return this;
        }
    }
}