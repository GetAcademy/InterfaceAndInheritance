using InterfaceAndInheritance.DomainModel;

namespace InterfaceAndInheritance.DomainServices
{
    interface IEmailService
    {
        void Send(Email email);
    }
}
