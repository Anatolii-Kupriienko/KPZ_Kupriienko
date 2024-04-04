namespace DecoratorClassLib
{
    public class Staff : Weapon
    {
        public int Range { get; private set; }

        public Staff(string name, int range) : base(name, 15)
        {
            Range = range;
        }

        public Staff() { }

        public override string Attack()
        {
            return $"ZAP";
        }
    }
}