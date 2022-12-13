using Lesson_17.Models.Domain;
using Lesson_17.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_17.Controllers
{
    [Controller]
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
        public IActionResult ReplaceProduct() => View();

        [HttpPost]
        public IActionResult ReplaceProduct(int idProduct, Product product)
        {

            return EditAndRedirect(idProduct, product);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            var allProducts = action.GetAllProducts();
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult DeleteProduct(Product product)
        {
            action.DeleteProduct(product);
            return RedirectToAction("GetAllProduct");
        }

        private IActionResult EditAndRedirect(int id, Product product)
        {
            if (product != null)
            {
                action.ReplaceProduct(id, product);
            }
            return RedirectToAction("GetAllProduct");
        }

        private IActionResult AddAndRedirect(Product pdto)
        {
            action.AddProduct(pdto);
            return RedirectToAction("GetAllProduct");
        }
    }
}
