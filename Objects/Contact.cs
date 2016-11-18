using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact{
    private string _name;
    private string _phone
    private string _street;
    private string _cityState;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string newName, string newPhone, string newStreet, string newCityState)
    {
      _name = newName;
      _phone = newPhone;
      _street = newStreet;
      _cityState = newCityState;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }
    public string GetCityState()
    {
      return _cityState;
    }
    public void SetCityState()
    {
      _cityState = newCityState;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
