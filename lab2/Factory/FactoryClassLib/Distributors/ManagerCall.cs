using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FactoryClassLib.Subscriptions;

namespace FactoryClassLib.Distributors
{
    public class ManagerCall : ISubscriptionDistributor
    {
        private User User = new User();
        public Subscription CreateSubscription(SubscriptionTypes type)
        {
            User.PhoneNumber = "555-555-5555"; //caller's phone number
            Console.WriteLine("Provide name:");
            User.Name = Console.ReadLine()!;
            Console.WriteLine("Provide email:");
            User.Email = Console.ReadLine()!;

            Console.WriteLine("Provide subscription duration in days:");
            int subscriptionDurationDays = int.Parse(Console.ReadLine()!);

            Subscription subscription = type switch
            { // can also initialize content here for different subscription types
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
