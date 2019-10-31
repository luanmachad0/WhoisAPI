using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View(new WhoisContext().WhoisParseds.ToList());
        }

        [HttpPost]
        public ActionResult SearchDomain(string domain)
        {
            var whois = new RequestApiWhois().SearchDomain(domain);
            var database = new WhoisContext();
            database.WhoisParseds.Add(whois);
            database.SaveChanges();

            return View("Index", whois);   
        }       
    }
}