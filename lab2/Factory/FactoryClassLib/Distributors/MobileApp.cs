using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryClassLib.Subscriptions;

namespace FactoryClassLib.Distributors
{
    public class MobileApp : ISubscriptionDistributor
    {
        private User User = new User();
        private bool UserAccountSetup = false;

        public void SetupUserAccount()
        {
            Console.WriteLine("Provide name:");
            User.Name = Console.ReadLine()!;
            Console.WriteLine("Provide email:");
            User.Email = Console.ReadLine()!;
            Console.WriteLine("Provide phone number:");
            User.PhoneNumber = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(User.Email) & !string.IsNullOrEmpty(User.Name) && !string.IsNullOrEmpty(User.PhoneNumber))
            {
                UserAccountSetup = true;
            }
        }
        public Subscription CreateSubscription(SubscriptionTypes type)
        {
            if (!UserAccountSetup)
            {
                throw new InvalidOperationException("User must provide all required information before creating a subscription");
            }

            Console.WriteLine("Choose a subscription type:");
            Console.WriteLine("1. Domestic");
            Console.WriteLine("2. Premium");
            Console.WriteLine("3. Educational");
            SubscriptionTypes subscriptionType = int.Parse(Console.ReadLine()!) switch
            {
                1 => SubscriptionTypes.Domestic,
                2 => SubscriptionTypes.Premium,
                3 => SubscriptionTypes.Educational,
                _ => throw new Exception("Invalid subscription type")
            };

            Console.WriteLine("Provide subscription duration in days:");
            uint subscriptionDurationDays = uint.Parse(Console.ReadLine()!);
            Subscription subscription = subscriptionType switch
            {
                SubscriptionTypes.Domestic => new DomesticSubscription(),
                SubscriptionTypes.Premium => new PremiumSubscription(),
                SubscriptionTypes.Educational => new EducationalSubscription(),
                _ => throw new Exception("Invalid subscription type")
            };
            User.Subscription = subscription.Continue(TimeSpan.FromDays(subscriptionDurationDays));
            return User.Subscription;
        }
    }
}