using SingletonDemo;

Authenticator authenticator1 = Authenticator.Instance;
Authenticator authenticator2 = Authenticator.Instance;

Authenticator authenticator3 = await Task.Run(() =>
{
    return Authenticator.Instance;
});

Console.WriteLine($"Are Authenticator1 and Authenticator2 the same instance? {authenticator1 == authenticator2}");
Console.WriteLine($"Are Authenticator1 and Authenticator3 the same instance? {authenticator1 == authenticator3}");
Console.WriteLine($"Are Authenticator2 and Authenticator3 the same instance? {authenticator2 == authenticator3}");
