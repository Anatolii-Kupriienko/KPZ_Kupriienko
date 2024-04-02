using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class YeskiaLaptop : Device, ILaptop
    {
        public bool isIDEOpen { get; set; } = false;

        public void CloseIDE()
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            if (isIDEOpen)
            {
                Console.WriteLine("Exiting Vim...");
                Console.WriteLine("Poistuminen Vim...");
            }
            else
            {
                Console.WriteLine("No IDE is open");
                Console.WriteLine("Mikään IDE ei ole auki");
            }
        }

        public void OpenIDE()
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            isIDEOpen = true;
            Console.WriteLine("Opening Vim...");
            Console.WriteLine("Avaaminen Vim...");
        }
    }
}