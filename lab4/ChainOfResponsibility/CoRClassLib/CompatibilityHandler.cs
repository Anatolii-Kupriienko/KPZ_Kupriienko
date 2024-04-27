namespace CoRClassLib
{
    public class CompatibilityHandler : AbstractHandler
    {
        public CompatibilityHandler()
        {
        }
        public CompatibilityHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("You can visit our website, where you cand find your device, specific model and check the compatibility.");
            return base.Handle(request);
        }
    }
}