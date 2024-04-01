using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryClassLib.Subscriptions;

namespace FactoryClassLib.Distributors
{
    public class WebSite : ISubscriptionDistributor
    {
        private User User = new User();
        public uint? SubscriptionDurationDays { get; private set; } = null;

        public void SetUserName(string name)
        {
            User.Name = name;
        }
        public void SetUserEmail(string email)
        {
            User.Email = email;
        }
        public void SetUserPhoneNumber(string phoneNumber)
        {
            User.PhoneNumber = phoneNumber;
        }
        public SubscriptionTypes ChooseSubscriptionType()
        {
            Console.WriteLine("Choose a subscription type:");
            Console.WriteLine("1. Domestic");
            Console.WriteLine("2. Premium");
            Console.WriteLine("3. Educational");
            return int.Parse(Console.ReadLine()!) switch
            {
                1 => SubscriptionTypes.Domestic,
                2 => SubscriptionTypes.Premium,
                3 => SubscriptionTypes.Educational,
                _ => throw new Exception("Invalid subscription type")
            };
        }
        public void ChooseSubscriptionDuration()
        {
            Console.WriteLine("Provide subscription duration in days:");
            SubscriptionDurationDays = uint.Parse(Console.ReadLine()!);
        }
        public Subscription CreateSubscription(SubscriptionTypes type)
        {
            if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.PhoneNumber))
            {
                throw new InvalidOperationException("User must provide all required information before creating a subscription");
            }
            Subscription subscription = type switch
            {
                SubscriptionTypes.Educational => new EducationalSubscription(),
                SubscriptionTypes.Domestic => new DomesticSubscription(),
                SubscriptionTypes.Premium => new PremiumSubscription(),
                _ => throw new NotImplementedException(),
            };

            if (SubscriptionDurationDays == null)
            {
                ChooseSubscriptionDuration();
            }
            User.Subscription = subscription.Continue(TimeSpan.FromDays((int)SubscriptionDurationDays));
            return User.Subscription;
        }
    }
}