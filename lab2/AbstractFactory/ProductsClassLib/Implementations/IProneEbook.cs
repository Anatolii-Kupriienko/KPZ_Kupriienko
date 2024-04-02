using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class IProneEbook : Device, IEBook
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
            }
            else
            {
                Console.WriteLine($"Closing book: {openBook}");
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
            openBook = bookName;
            Console.WriteLine($"Opening book: {bookName}");
        }

    }
}