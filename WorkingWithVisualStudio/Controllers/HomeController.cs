using WorkingWithVisualStudio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WorkingWithVisualStudio.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;
        public IActionResult Index() => View(Repository.Products);//.Where(p => p?.Price < 50));

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            Repository.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }


        //public IActionResult Index() => View(SimpleRepository.SharedRepository.Products.Where(p => p?.Price < 50));
    }
}
