namespace DecoratorClassLib
{
    public class CursedWeapon : DecoratedWeapon
    {
        public CursedWeapon(Weapon weapon) : base(weapon)
        {
            Name = "Cursed " + weapon.Name;
            Damage = weapon.Damage - 5;
        }

        public override string Attack()
        {
            return $"DARK {base.Attack()}";
        }
    }
}