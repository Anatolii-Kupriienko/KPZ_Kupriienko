
namespace ProxyClassLib
{
    public class SmartTextChecker : ISmartTextReader
    {
        private SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public List<(string, char[])> ReadFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Opened file successfully");
                var result = _reader.ReadFile(path);
                Console.WriteLine("Read file successfully");
                Console.WriteLine("Closed file successfully");
                return result;
            }
            else
            {
                throw new InvalidOperationException("File does not exist");
            }
        }
    }
}