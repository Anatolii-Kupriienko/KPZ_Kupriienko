namespace DecoratorClassLib
{
    //decorators for artifacts: Shadow, Holy, Arcane, Ancient, Legendary
    public abstract class Artifact
    {
        public string Name { get; set; }
        public string Ability { get; set; }
        public TimeSpan RechargeTime { get; set; }
        public int Charges { get; set; }

        public Artifact(string name, string ability, TimeSpan rechargeTime, int charges)
        {
            Name = name;
            Ability = ability;
            RechargeTime = rechargeTime;
            Charges = charges;
        }
        public Artifact() { }

        public virtual string Use()
        {
            if (Charges > 0)
            {
                if (string.IsNullOrEmpty(Ability))
                {
                    return $"{Name} has no ability!";
                }
                Charges--;
                return $"{Name} is used!";
            }
            else
            {
                return $"{Name} is out of charges!";
            }
        }
    }
}