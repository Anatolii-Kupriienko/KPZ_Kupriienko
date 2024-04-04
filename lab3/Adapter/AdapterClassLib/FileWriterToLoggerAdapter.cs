namespace AdapterClassLib
{
    public class FileWriterToLoggerAdapter : ILogger
    {
        private FileWriter _fileWriter;
        public FileWriterToLoggerAdapter(string path)
        {
            _fileWriter = new FileWriter(path);
        }
        public void Error(string message)
        {
            _fileWriter.WriteLine("Time: " + DateTime.Now + ";\tError: " + message);
        }

        public void Log(string message)
        {
            _fileWriter.WriteLine("Time: " + DateTime.Now + ";\tLog: " + message);
        }

        public void Warn(string message)
        {
            _fileWriter.WriteLine("Time: " + DateTime.Now + ";\tWarning: " + message);
        }
    }
}