namespace ProductsClassLib.Interfaces
{
    public interface ILaptop : IDevice
    {
        bool isIDEOpen { get; set; }
        void OpenIDE();
        void CloseIDE();
    }
}