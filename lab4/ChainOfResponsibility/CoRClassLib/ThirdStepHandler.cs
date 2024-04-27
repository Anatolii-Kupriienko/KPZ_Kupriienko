namespace CoRClassLib
{
    public class ThirdStepHandler : AbstractHandler
    {
        public ThirdStepHandler() { }

        public ThirdStepHandler(IHandler nextHandler) : base(nextHandler) { }

        public override object Handle(object request)
        {
            AbstractHandler nextHandler = null;
            string newRequest = "";
            while (true)
            {
                Console.WriteLine("Choose the problem you need help with:");
                Console.WriteLine("1. I can't find where to download the drivers for the device.");
                Console.WriteLine("2. I don't know if my device is compatible with your product.");
                Console.WriteLine("3. Other");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine()!.Trim();
                switch (choice)
                {
                    case "1":
                        nextHandler = new DriverDownloadHandler();
                        newRequest = "DownloadDrivers";
                        break;
                    case "2":
                        nextHandler = new CompatibilityHandler();
                        newRequest = "CompatibilityCheck";
                        break;
                    case "3":
                        nextHandler = new FourthStepHandler();
                        newRequest = "MenuStep4";
                        break;
                    case "4":
                        return base.Handle(request);
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                if (nextHandler != null)
                {
                    break;
                }
            }
            this.SetNext(nextHandler);
            return base.Handle(newRequest);
        }

    }
}