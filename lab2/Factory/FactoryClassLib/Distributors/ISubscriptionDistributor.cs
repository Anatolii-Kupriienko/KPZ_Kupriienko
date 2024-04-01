using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryClassLib.Subscriptions;

namespace FactoryClassLib.Distributors
{
    public interface ISubscriptionDistributor
    {
        Subscription CreateSubscription(SubscriptionTypes type);
    }
}