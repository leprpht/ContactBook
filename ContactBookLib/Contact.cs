using ContactBookConsole.Random_Info_Generator;

namespace ContactBookLib
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _address;
        public string Name => _name;
        public Contact(string name, string email, string phone, string address)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = address;
        }
        public Contact()
        {
            string[] nameAndEmail = RandomName.RandomFullNameAndEmail();
            _name = nameAndEmail[0];
            _email = nameAndEmail[1];
            _phone = RandomPhone.RandomPhoneNumber();
            _address = RandomAddress.RandomFullAddress();
        }
        public void UpdateContact(string name, string email, string phone, string address)
        {
            _name = name;
            _email = email;
            _phone = phone;
            _address = address;
        }
        public string GetContactInfo()
        {
            return $"Name: {_name}\nEmail: {_email}\nPhone: {_phone}\nAddress: {_address}";
        }
        public string GetName() => _name;
    }
}
