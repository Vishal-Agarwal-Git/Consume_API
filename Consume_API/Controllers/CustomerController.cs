using Microsoft.AspNetCore.Mvc;

namespace Consume_API.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
