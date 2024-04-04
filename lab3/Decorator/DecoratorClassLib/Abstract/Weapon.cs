namespace DecoratorClassLib
{
    //decorators for weapoon: Cursed, Magic, Blessed, Heavy, Light
    public abstract class Weapon
    {
        public virtual string Name { get; set; }
        public virtual int Damage { get; set; }
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public Weapon() { }

        public virtual string Attack()
        {
            return $"Attacked with {Name} for {Damage} damage!";
        }
    }
}