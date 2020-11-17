using WorkingWithVisualStudio.Models;
using Microsoft.AspNetCore.Mvc;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products);
    }
}
