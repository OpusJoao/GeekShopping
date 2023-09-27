using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.FindAllProducts();
            return View(products);
        }

		public async Task<IActionResult> Create()
		{
			return View();
		}

        [HttpPost]
		public async Task<IActionResult> Create(ProductModel product)
		{
            if (!ModelState.IsValid) return View(product);
            var response = await _productService.Create(product);
            if(response is null) return View(product);
			return RedirectToAction(nameof(Index));
		}

        public async Task<IActionResult> Update(long id)
        {
            var product = await _productService.FindById(id);
            if(product is null) return NotFound();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductModel product)
        {
            if (!ModelState.IsValid) return View(product);
            var response = await _productService.Update(product);
            if (response is null) return View(product);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(long id)
        {
            var product = await _productService.FindById(id);
            if (product is null) return NotFound();
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductModel product)
        {
            var response = await _productService.DeleteById(product.Id);
            if (response is false) return View(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
