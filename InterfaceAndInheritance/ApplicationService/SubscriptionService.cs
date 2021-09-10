using System;
using InterfaceAndInheritance.DomainModel;
using InterfaceAndInheritance.DomainServices;

namespace InterfaceAndInheritance.ApplicationService
{
    class SubscriptionService
    {
        private readonly IEmailService _emailService;
        private readonly INewsletterRepository _newsletterRepository;

        public SubscriptionService(IEmailService emailService, INewsletterRepository newsletterRepository)
        {
            _newsletterRepository = newsletterRepository;
            _emailService = emailService;
        }

        public void Subscribe(string emailAddress)
        {
            var code = Guid.NewGuid().ToString();
            var email = new Email(
                emailAddress, 
                "newsletter@getacademy.no", 
                "Bekreft ditt nyhetsbrev", 
                $"Koden er {code}");
            _emailService.Send(email);
            var subscription = new Subscription(emailAddress, code);
            _newsletterRepository.Save(subscription);
        }

        public bool Verify(string emailAddress, string code)
        {
            var subscription = _newsletterRepository.Get(emailAddress);
            if (subscription.VerificationCode != code) return false;
            subscription.Verify();
            _newsletterRepository.Save(subscription);
            return true;
        }
    }
}
