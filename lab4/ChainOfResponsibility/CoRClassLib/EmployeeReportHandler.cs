namespace CoRClassLib
{
    public class EmployeeReportHandler : AbstractHandler
    {
        public EmployeeReportHandler()
        {
        }
        public EmployeeReportHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Choose the employee you would like to report: ");
            Console.WriteLine("1. John Doe");
            Console.WriteLine("2. Jane Doe");
            Console.WriteLine("3. Joe Doe");
            Console.WriteLine("4. Jack Doe");
            Console.ReadLine();
            Console.WriteLine("Describe your problem with chosen employee: ");
            Console.ReadLine();
            Console.WriteLine("Thank you for your report. We will take care of it.");
            return base.Handle(request);
        }
    }
}