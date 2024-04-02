using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class YeskiaEBook : Device, IEBook
    {
        public string? openBook { get; set; }

        public void CloseBook()
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            if (string.IsNullOrEmpty(openBook))
            {
                Console.WriteLine("No book is open");
                Console.WriteLine("Mikään kirja ei ole auki");
            }
            else
            {
                Console.WriteLine($"Closing {openBook}");
                Console.WriteLine($"sulkeminen {openBook}");
                openBook = null;
            }
        }

        public void OpenBook(string bookName)
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            Console.WriteLine($"Opening book: {bookName}");
            Console.WriteLine($"Avauskirja: {bookName}");
        }
    }
}