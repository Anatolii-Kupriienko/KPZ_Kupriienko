namespace FactoryClassLib
{
    public class PremiumSubscription : Subscription
    {
        public override decimal Fee { get; protected set; } = 20.0m;
        public override TimeSpan MinDuration { get; protected set; } = TimeSpan.FromDays(14);
        public override bool CanDownload { get; protected set; } = true;
        public override string[] AvailableConent { get; init; }

        public PremiumSubscription(string[] avaliableConent)
        {
            AvailableConent = avaliableConent;
        }

        public PremiumSubscription()
        {
            AvailableConent = new string[] { "Math", "Science", "History", "Art", "Music" };
        }
    }
}