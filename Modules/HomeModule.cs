using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contact_form"] = _ => {
        return View["contact_form.cshtml"];
      };
      Get["/view_all_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml", allContacts];
      };

      Post["/contact_added"] = _ => {
        Contact newContact = new Contact (Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address-street"], Request.Form["new-city-state"]);
        newContact.Save();
        return View["contact_added.cshtml", newContact];
      };
      Post["/contacts_cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
      Get["/Contact/{id}"] = parameters =>
      {
        return View["contact_details.cshtml", Contact.Find(int.Parse(parameters.id))];
      };

      //###### search ######//
      Get["/search_by_name"] = _ => {
        return View["search_by_name.cshtml"];
      };
      Post["/Contact/search_results"] = _ => {
        string searchContactName = Request.Form["contact-name"];
        List<SearchContact> matchingContacts = SearchContact.GetMatchingContacts(searchContactName);
        return View["search_results.cshtml", matchingContacts];
      };
      //###### search ######//
    }
  }
}
