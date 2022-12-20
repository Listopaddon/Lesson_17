
using Lesson_17.Filters;
using Lesson_17.Models.Domain;
using Lesson_17.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_17.Controllers
{
    [Controller]
    [CheckCorrectDataFilter]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        ActionWithProducts action;
        public ProductController(ActionWithProducts action)
        {
            this.action = action;
        }

        [HttpGet]
        public IActionResult AddProduct() => View();

        [HttpPost]
        public IActionResult AddProduct(Product product) => AddAndRedirect(product);


        [HttpGet]
        public IActionResult ReplaceProduct(int id)
        {
            Product product = action.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult ReplaceProduct(Product product)
        {
            return EditAndRedirect(product);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var allProducts = action.GetAllProducts();
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            action.DeleteProduct(id);
            return RedirectToAction("GetAllProduct");
        }

        [HttpGet]
        public IActionResult ViewException()
        {
            return View();
        }

        private IActionResult EditAndRedirect(Product product)
        {

            if (product != null)
            {
                action.ReplaceProduct(product);
            }
            return RedirectToAction("GetAllProduct");
        }

        private IActionResult AddAndRedirect(Product pdto)
        {
            if (pdto.Price <= 0)
            {
                return RedirectToAction("ViewException");
            }
            action.AddProduct(pdto);
            return RedirectToAction("GetAllProduct");
        }


    }
}
