namespace CoRClassLib
{
    public class TechSupportMenu : AbstractHandler
    {
        public override object Handle(object request)
        {
            Console.WriteLine("Welcome to Tech Support. How can I help you?");
            Console.WriteLine("1. I forgot my password.");
            Console.WriteLine("2. Other technical issues.");
            Console.WriteLine("3. I would like to report one of your employees.");
            Console.WriteLine("4. Other");
            Console.WriteLine("5. Exit");

            AbstractHandler handler = null;
            string newRequest = "";
            while (true)
            {
                switch (Console.ReadLine()!.Trim())
                {
                    case "1":
                        handler = new PasswordResetHandler();
                        newRequest = "PasswordReset";
                        break;
                    case "2":
                        handler = new TechIssuesHandler();
                        newRequest = "TechIssues";
                        break;
                    case "3":
                        handler = new EmployeeReportHandler();
                        newRequest = "ReportEmployee";
                        break;
                    case "4":
                        handler = new ConnectToPersonHandler();
                        newRequest = "ConnectToPerson";
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        handler = new AbstractHandler();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                }
                
                if (handler != null)
                {
                    break;
                }
            }
            this.SetNext(handler);
            return base.Handle(newRequest);
        }
    }
}