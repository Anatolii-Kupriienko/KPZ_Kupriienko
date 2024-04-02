namespace ProductsClassLib.Interfaces
{
    public interface IEBook : IDevice
    {
        string? openBook { get; set; }
        void OpenBook(string bookName);
        void CloseBook();
    }
}