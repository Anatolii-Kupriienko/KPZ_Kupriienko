namespace DecoratorClassLib
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public Weapon? Weapon { get; set; }
        public List<Artifact> Artifacts { get; set; } = new List<Artifact>();

        public Character(string name, int health, int level, Weapon? weapon)
        {
            Name = name;
            Health = health;
            Level = level;
            Weapon = weapon;
        }
        public Character() { }
    }
}