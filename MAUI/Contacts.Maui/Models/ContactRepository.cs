using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact { Name="John Doe", Email="JohnDoe@mail.com"},
            new Contact { Name="Jane Doe", Email="JaneDoe@mail.com"},
            new Contact { Name="Tom Hanks", Email="TomHanks@mail.com"},
            new Contact { Name="Frank Liu", Email="FrankLiu@mail.com"},
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContact(int contactId)
        {
          return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
