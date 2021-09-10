using System.IO;
using InterfaceAndInheritance.DomainModel;
using InterfaceAndInheritance.DomainServices;

namespace InterfaceAndInheritance.Infrastructur
{
    class EmailService : IEmailService
    {
        public void Send(Email email)
        {
            var path = @"C:\Users\GetAcademy\Desktop\emailz.txt";
            var text = email.ToString();
            File.AppendAllText(path, text);
        }
    }
}
