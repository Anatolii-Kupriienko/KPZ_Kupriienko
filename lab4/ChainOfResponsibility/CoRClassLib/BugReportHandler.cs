namespace CoRClassLib
{
    public class BugReportHandler : AbstractHandler
    {
        public BugReportHandler()
        {
        }
        public BugReportHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Please provide a detailed description of the bug: ");
            Console.ReadLine();
            Console.WriteLine("Thank you for reporting the bug. We will investigate it shortly.");
            return base.Handle(request);
        }
    }
}