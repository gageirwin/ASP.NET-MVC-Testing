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

        public void thingy(string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CATALOG));
            XmlTextReader? xmlfile = new XmlTextReader(file);

            if (xmlfile == null) return;

            CATALOG? catalog = serializer.Deserialize(xmlfile) as CATALOG;

            if (catalog == null) return;

            if (catalog.CD == null) return;

            foreach (var item in catalog.CD)
            {
                if (item.OPTIONS == null)
                    Console.WriteLine($"Title: {item.TITLE}, Price: {item.PRICE}, Special: {item.SPECIAL}");
                else
                {
                    Console.WriteLine($"Title: {item.TITLE}, Price: {item.PRICE}, Special: {item.SPECIAL}, Options: {item.OPTIONS.Length}");

                    foreach (var option in item.OPTIONS)
                    {
                        Console.WriteLine($"\tindex: {option.index}, value: {option.Value}");
                    }
                }
            }
        }

        public IActionResult Index()
        {
            thingy("temp/cd_catalog.xml");
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
