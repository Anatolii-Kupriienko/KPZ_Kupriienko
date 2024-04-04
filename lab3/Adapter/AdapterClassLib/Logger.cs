namespace AdapterClassLib
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Time: " + DateTime.Now + ";\t" + message);
            Console.ResetColor();
        }

        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Time: " + DateTime.Now + ";\t" + message);
            Console.ResetColor();
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Time: " + DateTime.Now + ";\t" + message);
            Console.ResetColor();
        }
    }
}