namespace CoRClassLib
{
    public class AbstractHandler : IHandler
    {
        private IHandler NextHandler;

        public AbstractHandler()
        {
        }

        public AbstractHandler(IHandler nextHandler)
        {
            this.NextHandler = nextHandler;
        }
        public virtual object Handle(object request)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this.NextHandler = handler;
            return handler;
        }
    }
}