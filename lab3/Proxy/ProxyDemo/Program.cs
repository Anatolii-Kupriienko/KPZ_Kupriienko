
using ProxyClassLib;

var normalReader = new SmartTextReader();
var checker = new SmartTextChecker(normalReader);
var locker = new SmartTextReaderLocker(normalReader, "log");

var path = "log.txt";

var result = normalReader.ReadFile(path);
Console.WriteLine("Normal reader:");
foreach (var (line, chars) in result)
{
    Console.WriteLine($"Line: {line}");
    Console.WriteLine($"Chars ({chars.Length}): ");
    foreach (var c in chars)
    {
        Console.Write(c);
    }
}
Console.WriteLine();

Console.WriteLine("Checker:");
result = checker.ReadFile(path);
foreach (var (line, chars) in result)
{
    Console.WriteLine($"Line: {line}");
    Console.WriteLine($"Chars ({chars.Length}): ");
    foreach (var c in chars)
    {
        Console.Write(c);
    }
}
Console.WriteLine();

Console.WriteLine("Locker:");
try
{
    result = locker.ReadFile(path);
    foreach (var (line, chars) in result)
    {
        Console.WriteLine($"Line: {line}");
        Console.WriteLine($"Chars ({chars.Length}): ");
        foreach (var c in chars)
        {
            Console.Write(c);
        }
    }
    Console.WriteLine();
}
catch (InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}