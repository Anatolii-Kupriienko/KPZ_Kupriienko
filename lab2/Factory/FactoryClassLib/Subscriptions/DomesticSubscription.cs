namespace FactoryClassLib
{
    public class DomesticSubscription : Subscription
    {
        public override decimal Fee { get; protected set; } = 15.0m;
        public override TimeSpan MinDuration { get; protected set; } = TimeSpan.FromDays(7);
        public override bool CanDownload { get; protected set; } = false;
        public override string[] AvailableConent { get; init; }

        public DomesticSubscription()
        {
            AvailableConent = new string[]
            {
                "Local news",
                "Local weather",
                "Local sports"
            };
        }
    }
}