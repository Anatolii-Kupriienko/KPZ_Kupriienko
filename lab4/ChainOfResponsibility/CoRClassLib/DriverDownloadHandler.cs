namespace CoRClassLib
{
    public class DriverDownloadHandler : AbstractHandler
    {
        public DriverDownloadHandler()
        {
        }
        public DriverDownloadHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Visit our website and go to the FAQ page, where you will find a link to all the drivers.");
            return base.Handle(request);
        }
    }
}