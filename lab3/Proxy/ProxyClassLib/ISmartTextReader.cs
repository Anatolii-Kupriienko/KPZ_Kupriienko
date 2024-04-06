namespace ProxyClassLib
{
    public interface ISmartTextReader
    {
        List<(string, char[])> ReadFile(string path);
    }
}