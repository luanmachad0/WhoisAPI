using System;
using System.Collections.Generic;
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

        [HttpPost]
        public ActionResult SearchDomain(string domain)
        {
            var whois = new RequestApiWhois().SearchDomain(domain);
            return View("Index", whois);   
        }       
    }
}