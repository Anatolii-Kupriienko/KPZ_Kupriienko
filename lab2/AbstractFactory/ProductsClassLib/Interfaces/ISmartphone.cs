namespace ProductsClassLib.Interfaces
{
    public interface ISmartphone : IDevice
    {
        string? inCallWithPhoneNumber { get; set; }
        void Call(string phoneNumber);
        void HangUp();
    }
}