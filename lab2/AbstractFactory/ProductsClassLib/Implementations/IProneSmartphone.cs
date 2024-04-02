using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class IProneSmartphone : Device, ISmartphone
    {
        public string? inCallWithPhoneNumber { get; set; }

        public void Call(string phoneNumber)
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            inCallWithPhoneNumber = phoneNumber;
            Console.WriteLine($"Calling {phoneNumber}");
        }

        public void HangUp()
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            if (string.IsNullOrEmpty(inCallWithPhoneNumber))
            {
                Console.WriteLine("No call is ongoing");
            }
            else
            {
                Console.WriteLine($"Hanging up call with {inCallWithPhoneNumber}");
                inCallWithPhoneNumber = null;
            }
        }
    }
}