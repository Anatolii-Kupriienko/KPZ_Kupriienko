namespace FactoryClassLib
{
    public class EducationalSubscription : Subscription
    {
        public override decimal Fee { get; protected set; } = 10.0m;
        public override TimeSpan MinDuration { get; protected set; } = TimeSpan.FromDays(30);
        public override bool CanDownload { get; protected set; } = true;
        public override string[] AvailableConent { get; init; }

        public EducationalSubscription(string[] avaliableConent)
        {
            AvailableConent = avaliableConent;
        }

        public EducationalSubscription()
        {
            AvailableConent = new string[] { "Math", "Science", "History" };
        }
    }
}