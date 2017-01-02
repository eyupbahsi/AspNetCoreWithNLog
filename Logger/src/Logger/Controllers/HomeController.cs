using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Logger
{
    public class HomeController : Controller
    {
        readonly ILogger<HomeController> _log;

        public HomeController(ILogger<HomeController> log)
        {
            _log = log;


        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var identifier = HttpContext.TraceIdentifier;

            _log.LogInformation(identifier + "info");
            _log.LogError(identifier + "error");

            return View();
        }
    }
}
