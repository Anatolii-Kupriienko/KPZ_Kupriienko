using System.Text.RegularExpressions;

namespace ProxyClassLib
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private SmartTextReader _reader;
        private string lockedRegEx;

        public SmartTextReaderLocker(SmartTextReader reader, string lockedRegEx)
        {
            _reader = reader;
            this.lockedRegEx = lockedRegEx;
        }

        public void SetLockedRegEx(string lockedRegEx)
        {
            this.lockedRegEx = lockedRegEx;
        }

        public List<(string, char[])> ReadFile(string path)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);
            Match match = Regex.Match(fileName, lockedRegEx);
            if (match.Success)
            {
                throw new InvalidOperationException("Access denied!");
            }
            return _reader.ReadFile(path);
        }
    }
}