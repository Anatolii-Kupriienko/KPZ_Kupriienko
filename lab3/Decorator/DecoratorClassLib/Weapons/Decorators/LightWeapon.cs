namespace DecoratorClassLib
{
    public class LightWeapon : DecoratedWeapon
    {
        public LightWeapon(Weapon weapon) : base(weapon)
        {
            Name = "Light " + _weapon.Name;
            Damage = _weapon.Damage - 5;
        }

        public override string Attack()
        {
            return $"SMALL {base.Attack()}";
        }
    }
}