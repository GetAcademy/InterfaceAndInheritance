using System.IO;
using InterfaceAndInheritance.DomainModel;
using InterfaceAndInheritance.DomainServices;

namespace InterfaceAndInheritance.Infrastructur
{
    class NewsletterRepository : INewsletterRepository
    {
        public void Save(Subscription subscription)
        {
            var path = @"C:\Users\GetAcademy\Desktop\subscriptionz.txt";
            var text = subscription.EmailAddress + "," +
            subscription.VerificationCode + "," +
            subscription.IsVerified;
            File.WriteAllText(path, text);
        }

        public Subscription Get(string email)
        {
            var path = @"C:\Users\GetAcademy\Desktop\subscriptionz.txt";
            var text = File.ReadAllText(path);
            var parts = text.Split(',');
            var subscription = new Subscription(parts[0], parts[1]);
            if(parts[2]=="true")subscription.Verify();
            return subscription;
        }
    }
}
