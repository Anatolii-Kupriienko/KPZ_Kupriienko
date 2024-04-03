using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderClassLib
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Nickname { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public void DoStuff(string stuff)
        {
            switch (Type.ToLower())
            {
                case "hero":
                    if (stuff.ToLower().Contains("bad"))
                    {
                        Console.WriteLine("Hero doesn't do bad stuff");
                        return;
                    }
                    break;
                case "enemy":
                    if (stuff.ToLower().Contains("good"))
                    {
                        Console.WriteLine("Enemy doesn't do good stuff");
                        return;
                    }
                    break;
            }
            Console.WriteLine($"{Name} is doing {stuff}");
        }

        public override string ToString()
        {
            return $"{Name} the {Class} is a level {Level} {Type} with {Health} health and is known as {Nickname}";
        }
    }
}