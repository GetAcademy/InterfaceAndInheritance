namespace InterfaceAndInheritance
{
    interface INewsletterRepository
    {
        void Save(Subscription subscription);
        Subscription Get(string email);
    }
}
