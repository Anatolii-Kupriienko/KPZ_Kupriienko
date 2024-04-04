namespace DecoratorClassLib
{
    public class Warrior : Character
    {
        public int MaxRage { get; set; }
        public List<string> Abilities { get; set; } = new List<string>();

        public Warrior(string name, int health, int level, int maxRage, Weapon? weapon) : base(name, health, level, weapon)
        {
            MaxRage = maxRage;
        }

        public void LearnAbility(string abilityName)
        {
            if (!Abilities.Contains(abilityName))
            {
                Abilities.Add(abilityName);
            }
        }

        public void ForgetAbility(string abilityName)
        {
            if (Abilities.Contains(abilityName))
            {
                Abilities.Remove(abilityName);
            }
        }

        public void UseAbility(string abilityName)
        {
            if (Abilities.Contains(abilityName))
            {
                Console.WriteLine($"{Name} uses {abilityName}");
            }
            else
            {
                Console.WriteLine($"{Name} does not know the ability {abilityName}");
            }
        }
    }
}