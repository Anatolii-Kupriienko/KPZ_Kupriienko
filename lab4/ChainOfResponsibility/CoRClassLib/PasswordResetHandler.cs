namespace CoRClassLib
{
    public class PasswordResetHandler : AbstractHandler
    {
        public PasswordResetHandler()
        {
        }
        public PasswordResetHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            Console.WriteLine("Open our website and reset your password there.");
            return base.Handle(request);
        }
    }
}