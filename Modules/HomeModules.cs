using Nancy;
using System;
using System.Collections.Generic;
using Contact.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/all_contacts"] = _ => {
          List<Contact> allContacts = Contact.GetContacts();
          return View["view_contacts.cshtml", allContacts];
      };
      Post["/add_contact"] = _ => {
          Contact newContact = new Contact(Request.Form[""], Request.Form[""], Request.Form[""]);
          return View["created_contact.cshtml", newContact];
      };
    }
  }
}
