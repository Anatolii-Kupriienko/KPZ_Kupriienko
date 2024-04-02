using FactoryClassLib.Subscriptions;

namespace FactoryClassLib.Distributors
{
    public interface ISubscriptionDistributor
    {
        Subscription CreateSubscription(SubscriptionTypes type);
    }
}