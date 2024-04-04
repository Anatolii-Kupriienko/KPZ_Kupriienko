namespace DecoratorClassLib
{
    public class BlessedWeapon : DecoratedWeapon
    {
        public BlessedWeapon(Weapon weapon) : base(weapon)
        {
            Name = "Blessed " + weapon.Name;
            Damage = weapon.Damage + 5;
        }

        public override string Attack()
        {
            return "Blessed " + base.Attack();
        }
    }
}