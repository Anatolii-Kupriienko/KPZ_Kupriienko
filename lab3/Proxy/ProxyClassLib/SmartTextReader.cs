namespace ProxyClassLib
{
    public class SmartTextReader : ISmartTextReader
    {
        // there is no way that I know of to create a 2D array where first is string and second is char[]
        // so this list with a custom type is used instead 
        public List<(string, char[])> ReadFile(string path)
        {
            var lines = File.ReadAllLines(path);
            List<(string, char[])> result = new List<(string, char[])>();
            for (int i = 0; i < lines.Length; i++)
            {
                var chars = lines[i].ToCharArray();
                result.Add((lines[i], chars));
            }
            return result;
        }
    }
}