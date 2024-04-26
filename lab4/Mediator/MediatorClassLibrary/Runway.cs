namespace MediatorClassLibrary
{
    public class Runway
    {
        protected IMediator Mediator;
        public readonly Guid Id = Guid.NewGuid();

        public Runway() { }

        public Runway(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public bool CheckIsActive()
        {
            return Mediator.Notify(this, "is active");
        }

        public void HighlightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighlightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}