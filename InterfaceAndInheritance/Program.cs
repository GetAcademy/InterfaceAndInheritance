using System;
using InterfaceAndInheritance.ApplicationService;
using InterfaceAndInheritance.Infrastructur;
using ProjectB;

namespace InterfaceAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailService = new EmailService();
            var newsletterRepository = new NewsletterRepository();
            var subscriptionService = new SubscriptionService(emailService, newsletterRepository);
            string code = "jh";
            subscriptionService.Subscribe("terje@getacademy.no");
            subscriptionService.Verify("terje@getacademy.no", code);

            var classB = new ClassB();
        }
    }
}
