using System.Collections.Generic;

namespace AddressBook.Objects
{
    public class Contact
    {
        private string _name;
        private string _address;
        private string _phoneNumber;
        private string _city;
        private string _state;
        private int _zip;
        private static List<Contact> _allContacts = new List<Contact> {};

        public Contact(string Name, string PhoneNumber, string Address, string City, string State, int Zip)
        {
            _name = Name;
            _address = Address;
            _phoneNumber = PhoneNumber;
            _city = City;
            _state = State;
            _zip = Zip;
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
        public string GetCity()
        {
            return _city;
        }
        public void SetCity(string NewCity)
        {
            _city = NewCity;
        }
        public string GetState()
        {
            return _state;
        }
        public void SetState(string NewState)
        {
            _state = NewState;
        }
        public int GetZip()
        {
            return _zip;
        }
        public void SetZip(string NewZip)
        {
            _zip = NewZip;
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
