using System.Linq;
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
        [OutputCache(Duration = 120)]
        public ActionResult SearchDomain(string domain)
        {
            var whois = new RequestApiWhois().SearchDomain(domain);
            var database = new WhoisContext();
            var content = new WhoisParsed();
            database.WhoisParseds.Add(content);
            database.SaveChanges();

            return View("Index", whois);   
        }       
    }
}