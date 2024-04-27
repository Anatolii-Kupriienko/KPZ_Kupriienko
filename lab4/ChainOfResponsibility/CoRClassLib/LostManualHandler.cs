namespace CoRClassLib
{
    public class LostManualHandler : AbstractHandler
    {
        public LostManualHandler()
        {
        }
        public LostManualHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Visit our website to find and download the manual.");
            return base.Handle(request);
        }
    }
}