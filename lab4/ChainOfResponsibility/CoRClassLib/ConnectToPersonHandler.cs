namespace CoRClassLib
{
    public class ConnectToPersonHandler : AbstractHandler
    {
        public ConnectToPersonHandler()
        {
        }
        public ConnectToPersonHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override object Handle(object request)
        {
            // this is what I think I should do in every handler but I don't want hard-coded strings to every handler.
            // so let's imagine that this will be used correctly always.
            // if (!(request is string) || (request as string) != "ConnectToPerson")
            // {
            //     return base.Handle(request);
            // }
            Console.WriteLine("Connecting you to a person who can help you.");
            Console.WriteLine("Something went wrong. Call another time.");
            return base.Handle(request);
        }
    }
}