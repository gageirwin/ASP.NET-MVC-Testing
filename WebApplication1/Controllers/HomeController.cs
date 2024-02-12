using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CATALOG));
            CATALOG catalog = (CATALOG)serializer.Deserialize(new XmlTextReader("temp/cd_catalog.xml"));

            foreach (var item in catalog.CD)
            {
                Console.WriteLine($"Title: {item.TITLE}, Price: {item.PRICE}, Special: {item.SPECIAL}, Options: {item.OPTIONS.THING1}, {item.OPTIONS.THING2}");
            }





            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
