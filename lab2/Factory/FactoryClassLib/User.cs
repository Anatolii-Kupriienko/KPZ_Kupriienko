using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryClassLib.Subscriptions;

namespace FactoryClassLib
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Subscription Subscription {get; set;}
    }
}