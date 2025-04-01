using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookLib
{
    public class ContactBook
    {
        private Dictionary<string, Contact> _contacts = new Dictionary<string, Contact>();
        public Dictionary<string, Contact> Contacts => _contacts;
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact.Name, contact);
        }
        public void UpdateContact(string name, string email, string phone, string address)
        {
            if (_contacts.ContainsKey(name))
            {
                _contacts[name].UpdateContact(name, email, phone, address);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
        public string GetContactInfo(string name)
        {
            if (_contacts.ContainsKey(name))
            {
                return _contacts[name].GetContactInfo();
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return name;
            }
        }
        public string ListAllContacts()
        {
            string allContacts = "";
            foreach (KeyValuePair<string, Contact> contact in _contacts)
            {
                allContacts += contact.Value.GetContactInfo() + "\n\n";
            }
            return allContacts;
        }
    }
}
