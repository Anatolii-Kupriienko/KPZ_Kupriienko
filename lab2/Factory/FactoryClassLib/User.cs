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