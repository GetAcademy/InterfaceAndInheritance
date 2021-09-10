namespace InterfaceAndInheritance.DomainModel
{
    class Email 
    {
        public string To { get; }
        public string From { get; }
        public string Subject { get; }
        public string Text { get; }

        public Email(string to, string from, string subject, string text)
        {
            To = to;
            From = from;
            Subject = subject;
            Text = text;
        }

        public override string ToString()
        {
            return $"{To},{From},{Subject},{Text}";
        }
    }
}
