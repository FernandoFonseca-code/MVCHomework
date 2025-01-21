using Microsoft.AspNetCore.Mvc;

namespace MVCHomework.Controllers
{
    public class PCController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
