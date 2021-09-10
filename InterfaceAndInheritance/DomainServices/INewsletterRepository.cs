using InterfaceAndInheritance.DomainModel;

namespace InterfaceAndInheritance.DomainServices
{
    interface INewsletterRepository
    {
        void Save(Subscription subscription);
        Subscription Get(string email);
    }
}
