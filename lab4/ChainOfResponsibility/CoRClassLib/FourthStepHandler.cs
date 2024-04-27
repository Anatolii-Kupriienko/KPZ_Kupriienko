namespace CoRClassLib
{
    public class FourthStepHandler : AbstractHandler
    {
        public FourthStepHandler() { }

        public FourthStepHandler(IHandler nextHandler) : base(nextHandler) { }

        public override object Handle(object request)
        {
            AbstractHandler nextHandler = null;
            string newRequest = "";
            while (true)
            {
                Console.WriteLine("Choose the problem you need help with:");
                Console.WriteLine("1. I want to speak to one of your engineers.");
                Console.WriteLine("2. I want to report a bug.");
                Console.WriteLine("3. None of the above.");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine()!.Trim();
                switch (choice)
                {
                    case "1":
                        nextHandler = new ConnectToPersonHandler();
                        newRequest = "ConnectToPerson";
                        break;
                    case "2":
                        nextHandler = new BugReportHandler();
                        newRequest = "BugReport";
                        break;
                    case "3":
                        nextHandler = new TechSupportMenu();
                        break;
                    case "4":
                        nextHandler = new AbstractHandler();
                        break;
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