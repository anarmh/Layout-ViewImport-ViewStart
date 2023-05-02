using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModel.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
