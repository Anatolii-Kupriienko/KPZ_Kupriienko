namespace MediatorClassLibrary
{
    public class Aircraft
    {
        protected IMediator Mediator;
        public string Name;
        public bool IsAirborne { get; set; }

        public Aircraft(string name)
        {
            Name = name;
            IsAirborne = false;
        }
        public Aircraft(string name, IMediator mediator)
        {
            Name = name;
            this.Mediator = mediator;
            IsAirborne = false;
        }

        public void SetMediator(IMediator mediator)
        {
            this.Mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"{this.Name} is trying to land...");
            if (Mediator.Notify(this, "landing"))
            {
                IsAirborne = false;
            }
            else
            {
                Console.WriteLine($"{this.Name} is unable to land!. No available runways");
            }

            if (!IsAirborne)
            {
                Mediator.Notify(this, "landed");
                Console.WriteLine($"{this.Name} Landed!");
            }
        }

        public void TakeOff()
        {
            Console.WriteLine($"{this.Name} is trying to take off...");
            if (Mediator.Notify(this, "taking off"))
            {
                IsAirborne = true;
            }
            else
            {
                Console.WriteLine($"{this.Name} is unable to take off!. No available runways");
            }

            if (IsAirborne)
            {
                Mediator.Notify(this, "took off");
                Console.WriteLine($"{this.Name} Took off!");
            }
        }
    }
}