using Microsoft.AspNetCore.Mvc;

namespace Currency_Converter_App2.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
