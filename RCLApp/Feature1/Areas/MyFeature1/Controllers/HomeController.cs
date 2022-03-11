using Microsoft.AspNetCore.Mvc;

namespace Feature1.Areas.MyFeature1.Controllers
{
    public class HomeController : Controller
    {
        [Area("MyFeature1")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
