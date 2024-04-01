using FactoryClassLib;
using FactoryClassLib.Distributors;
using FactoryClassLib.Subscriptions;

//The different subscriptions' createtion approaches are not that much different tbh
//but in the demo-like environment, like this is, hard to think of something else
//that will not take too much time.

ManagerCall managerCall = new ManagerCall();
WebSite webSite = new WebSite();
MobileApp mobileApp = new MobileApp();

Console.WriteLine("Manager call:");
var managerSubscription = managerCall.CreateSubscription(SubscriptionTypes.Premium);

webSite.SetUserName("John Doe");
webSite.SetUserEmail("johndoe@mail.com");
webSite.SetUserPhoneNumber("123456789");
Console.WriteLine("WebSite:");
webSite.ChooseSubscriptionDuration();
SubscriptionTypes webSiteSubscriptionType = webSite.ChooseSubscriptionType();
var webSiteSubscription = webSite.CreateSubscription(webSiteSubscriptionType);

Console.WriteLine("MobileApp:");
mobileApp.SetupUserAccount();
var mobileAppSubscription = mobileApp.CreateSubscription(SubscriptionTypes.Domestic);


Console.WriteLine("Manager subscription:");
Console.WriteLine(managerSubscription.ToString());

Console.WriteLine("WebSite subscription:");
Console.WriteLine(webSiteSubscription.ToString());

Console.WriteLine("MobileApp subscription:");
Console.WriteLine(mobileAppSubscription.ToString());