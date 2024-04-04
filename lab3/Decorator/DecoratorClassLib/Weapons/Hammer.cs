namespace DecoratorClassLib
{
    public class Hammer : Weapon
    {
        public Hammer(string name) : base(name, 20) { }

        public Hammer() { }

        public override string Attack()
        {
            return $"BONK";
        }
    }
}