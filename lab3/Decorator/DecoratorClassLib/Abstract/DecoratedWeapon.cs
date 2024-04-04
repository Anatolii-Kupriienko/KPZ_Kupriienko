namespace DecoratorClassLib
{
    public abstract class DecoratedWeapon : Weapon
    {
        protected Weapon _weapon;

        public DecoratedWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void SetWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }

        public override string Attack()
        {
            if (_weapon != null)
                return _weapon.Attack();
            else
                return base.Attack();
        }
    }
}