using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact{
    private string _name;
    private string _phone;
    private string _street;
    private string _cityState;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string newName, string newPhone, string newStreet, string newCityState)
    {
      _name = newName;
      _phone = newPhone;
      _street = newStreet;
      _cityState = newCityState;
      _instances.Add(this);
      _id = _instances.Count;
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
    public void SetCityState(string newCityState)
    {
      _cityState = newCityState;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
