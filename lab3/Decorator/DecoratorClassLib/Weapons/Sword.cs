namespace DecoratorClassLib
{
    public class Sword : Weapon
    {
        public int Durability { get; private set; }

        public Sword(string name, int durability) : base(name, 15)
        {
            Durability = durability;
        }

        public Sword() { }

        public override string Attack()
        {
            if (Durability > 0)
            {
                Durability--;
                return $"SLASH";
            }
            else
            {
                return $"{Name} is broken!" ;
            }
        }

        public void Repair()
        {
            Durability = 10;
            Console.WriteLine($"{Name} is repaired!");
        }
    }
}