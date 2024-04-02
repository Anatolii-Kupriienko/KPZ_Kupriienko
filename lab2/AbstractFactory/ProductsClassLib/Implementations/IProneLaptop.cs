using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class IProneLaptop : Device, ILaptop
    {
        public bool isIDEOpen { get; set; }

        public void CloseIDE()
        {

            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            if (isIDEOpen)
            {
                Console.WriteLine("Skill issue: cannot exit Vim");
            }
            else
            {
                Console.WriteLine("No IDE is open");
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
        }
    }
}