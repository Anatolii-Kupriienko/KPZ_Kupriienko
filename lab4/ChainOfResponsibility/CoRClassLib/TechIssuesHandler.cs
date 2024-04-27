namespace CoRClassLib
{
    public class TechIssuesHandler : AbstractHandler
    {
        public TechIssuesHandler() { }

        public TechIssuesHandler(IHandler nextHandler) : base(nextHandler) { }

        // I think this is very bad but I don't have a damn clue how to do it better
        // especially with the task being a menu and so broad
        // that there are, I feel like, a million ways to do this and all of them aren't good
        // at least in the setting of just a demo
        // such a task is set out to be either disgusting if you try to make a quick demo 
        // or way too complex for a lab task if you do it properly.

        // although I might just be dumb and not see the obvious solution or overthink this too much
        public override object Handle(object request)
        {
            AbstractHandler nextHandler = null;
            string newRequest = "";
            while (true)
            {
                Console.WriteLine("Choose the problem you need help with:");
                Console.WriteLine("1. I've lost my manual.");
                Console.WriteLine("2. My device doesn't recognize your product");
                Console.WriteLine("3. Other");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine()!.Trim();
                switch (choice)
                {
                    case "1":
                        nextHandler = new LostManualHandler();
                        newRequest = "LostManual";
                        break;
                    case "2":
                        nextHandler = new BasicSetupHandler();
                        newRequest = "NoRecognition";
                        break;
                    case "3":
                        nextHandler = new ThirdStepHandler();
                        newRequest = "MenuStep3";
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