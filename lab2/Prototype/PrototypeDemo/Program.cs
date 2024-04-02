
using PrototypeDemo;

int count = 5;

IPrototype[] firstGen = new IPrototype[count];
for (int i = 0; i < count; i++)
{
    firstGen[i] = new Prototype(100, 10, "Parent", "Parent");
}

IPrototype[] secondGen = new IPrototype[count];
for (int i = 0; i < count; i++)
{
    var clone = firstGen[i].CLone(true);
    firstGen[i].Children.Add(clone);
    secondGen[i] = clone;
}

IPrototype[] thirdGen = new IPrototype[count];

for (int i = 0; i < count; i++)
{
    var clone = secondGen[i].CLone(true);
    secondGen[i].Children.Add(clone);
    thirdGen[i] = clone;
}

Console.WriteLine("First Gen");
foreach (var item in firstGen)
{
    Console.WriteLine(item);
}
Console.WriteLine("Second Gen");
foreach (var item in secondGen)
{
    Console.WriteLine(item);
}
Console.WriteLine("Third Gen");
foreach (var item in thirdGen)
{
    Console.WriteLine(item);
}