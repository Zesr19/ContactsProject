using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            // Aquí debe ir la acción para mostrar todos los contactos.
            //return View();
            List<ContactsModel> contactos = new List<ContactsModel> { 
                new ContactsModel { Id = 1, Name = "Eduardo Tovar", Nickname = "Lalo", Email = "eduardo@gmail.com", Telephone = "4448525123" },
                new ContactsModel { Id = 2, Name = "Jose Luis", Nickname = "Luis", Email = "joseluis@gmail.com", Telephone = "1234567890" },
                new ContactsModel { Id = 3, Name = "Luis Enrique", Nickname = "Enrique", Email = "luisenrique@gmail.com", Telephone = "4440123456" }
            };
            //ViewBag.MyContacts = contactos;
            return View(contactos);
        }
    }
}