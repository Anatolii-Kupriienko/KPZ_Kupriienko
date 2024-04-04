using System.Text;

namespace AdapterClassLib
{
    public class FileWriter
    {
        private string _path;
        public FileWriter(string path)
        {
            _path = path;
        }
        public void Write(string content)
        {
            using (var writer = new FileStream(_path, FileMode.Append))
            {
                writer.Write(Encoding.UTF8.GetBytes(content));
            }
        }
        public void WriteLine(string content)
        {
            if (!content.EndsWith(Environment.NewLine))
            {
                content += Environment.NewLine;
            }
            using (var writer = new FileStream(_path, FileMode.Append))
            {
                writer.Write(Encoding.UTF8.GetBytes(content));
            }
        }
    }
}