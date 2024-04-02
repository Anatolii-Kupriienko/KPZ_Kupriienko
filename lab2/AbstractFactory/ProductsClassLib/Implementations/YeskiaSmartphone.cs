using ProductsClassLib.Interfaces;

namespace ProductsClassLib.Implementations
{
    public class YeskiaSmartphone : Device, ISmartphone
    {
        public string? inCallWithPhoneNumber { get; set; }

        public void Call(string phoneNumber)
        {
            if (!isOn)
            {
                Console.WriteLine("Device is off");
                return;
            }
            if (!string.IsNullOrEmpty(inCallWithPhoneNumber))
            {
                Console.WriteLine("Cannot make a call while another call is ongoing");
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