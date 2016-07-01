using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Contact
    {
        private string _name;
        private string _address;
        private string _phoneNumber;
        private static List<Contact> _allContacts = new List<Contact> {};

        public Contact(string Name, string PhoneNumber, string Address)
        {
            _name = Name;
            _address = Address;
            _phoneNumber = PhoneNumber;
            _allContacts.Add(this);
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string NewName)
        {
            _name = NewName;
        }
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string NewAddress)
        {
            _address = NewAddress;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public void SetPhoneNumber(string NewPhoneNumber)
        {
            _phoneNumber = NewPhoneNumber;
        }
        public static List<Contact> GetContacts()
        {
            return _allContacts;
        }
        public static void ClearAll()
        {
          _allContacts.Clear();
        }
    }
}
