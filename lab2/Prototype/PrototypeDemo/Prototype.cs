using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class Prototype : IPrototype
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<IPrototype> Children { get; set; }

        public Prototype(double weight, int age, string name, string type, List<IPrototype> children)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = children;
        }
        public Prototype(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<IPrototype>();
        }

        public IPrototype CLone(bool deep = false)
        {
            if (deep)
            {
                List<IPrototype> newChildren = new List<IPrototype>();
                foreach (var child in Children)
                {
                    newChildren.Add(child.CLone(true));
                }
                return new Prototype(Weight, Age, Name, Type, newChildren);
                // another way to do it
                // return new Prototype(Weight, Age, Name, Type, Children.Select(c => c.CLone(true)).ToArray());
            }
            else
            {
                return new Prototype(Weight, Age, Name, Type, this.Children);
            }
        }

        public override string ToString()
        {
            string output = $"Name: {Name}, Type: {Type}, Age: {Age}, Weight: {Weight} Children: {Children.Count()}\n";
            if (Children.Count() > 0)
            {
                foreach (var child in Children)
                {
                    output += $"{child}\n;";
                }
            }
            return output;
        }
    }
}