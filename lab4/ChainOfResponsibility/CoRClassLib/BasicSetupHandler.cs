namespace CoRClassLib
{
    public class BasicSetupHandler : AbstractHandler
    {
        public BasicSetupHandler()
        {
        }
        public BasicSetupHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Make sure you have connected the device to the power supply and turned it on.");
            Console.WriteLine("If you've done that, please refernece the manual for further instructions.");
            Console.WriteLine("If you've lost the manual or still have problems with the device, check other options on the menu.");
            return base.Handle(request);
        }
    }
}