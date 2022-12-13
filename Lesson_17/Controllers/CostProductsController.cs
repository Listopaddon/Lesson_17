using Lesson_17.Models.Domain;
using Lesson_17.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_17.Controllers
{
    [Controller]
    [Route("[controller]/[action]")]
    public class CostProductsController : Controller
    {
        ActionWithProducts action;
        public CostProductsController(ActionWithProducts action)
        {
            this.action = action;
        }

        [HttpGet]
        public IActionResult SummAllProduct()
        {
            decimal result = action.SummAllProducts();
            return View(result);
        }

        [HttpGet]
        public IActionResult SummProductType(TypeProducts type)
        {
            return Ok(action.SummProductsOnType(type));
        }
    }
}
