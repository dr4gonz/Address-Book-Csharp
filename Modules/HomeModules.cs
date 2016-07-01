using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

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
      Get["/add_contact"] = _ => {
          return View["add_contact.cshtml"];
      };
      Post["/add_contact"] = _ => {
          Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], Request.Form["contact-address"]);
          return View["created_contact.cshtml", newContact];
      };
    }
  }
}
