using Sofrecom.Crm.BusinessLogicLayer;
using Sofrecom.Crm.Console.Extensions.V2;

namespace Sofrecom.Crm.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils utils = new Utils();
            ContactService contactService = new ContactService();
            string contactName = contactService.Load(1);
            System.Console.WriteLine(contactName);
        }
    }
}
