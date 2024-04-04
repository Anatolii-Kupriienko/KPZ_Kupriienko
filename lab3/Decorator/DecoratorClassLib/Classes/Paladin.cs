namespace DecoratorClassLib
{
    public class Paladin : Character
    {
        public int Mana { get; set; }
        public List<string> Spells { get; set; } = new List<string>();

        public Paladin(string name, int health, int level, int mana, Weapon? weapon) : base(name, health, level, weapon)
        {
            Mana = mana;
        }

        public void LearnSpell(string spellName)
        {
            if (!Spells.Contains(spellName))
            {
                Spells.Add(spellName);
            }
        }

        public void ForgetSpell(string spellName)
        {
            if (Spells.Contains(spellName))
            {
                Spells.Remove(spellName);
            }
        }

        public void CastSpell(string spellName)
        {
            if (Spells.Contains(spellName))
            {
                Console.WriteLine($"{Name} casts {spellName}");
            }
            else
            {
                Console.WriteLine($"{Name} does not know the spell {spellName}");
            }
        }
    }
}