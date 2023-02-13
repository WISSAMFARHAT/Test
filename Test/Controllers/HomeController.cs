using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Test.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("test")]
        public IActionResult Test()
        {
            return View();
        }

    }
}