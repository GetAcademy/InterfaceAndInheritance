namespace InterfaceAndInheritance.DomainModel
{
    class Subscription
    {
        public string EmailAddress { get; }
        public string VerificationCode { get; }
        public bool IsVerified { get; private set; }

        public Subscription(string emailAddress, string verificationCode)
        {
            EmailAddress = emailAddress;
            VerificationCode = verificationCode;
        }

        public void Verify()
        {
            IsVerified = true;
        }
    }
}
