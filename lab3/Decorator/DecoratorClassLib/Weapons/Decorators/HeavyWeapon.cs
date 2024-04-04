namespace DecoratorClassLib
{
    public class HeavyWeapon : DecoratedWeapon
    {
        public HeavyWeapon(Weapon weapon) : base(weapon)
        {
            Name = "Heavy " + _weapon.Name;
            Damage = _weapon.Damage + 10;
        }

        public override string Attack()
        {
            return $"BIG {base.Attack()}";
        }
    }
}