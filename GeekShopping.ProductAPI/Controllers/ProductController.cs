using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _productRepository.FindAll();
            if (products == null) return NotFound();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _productRepository.FindById(id);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create([FromBody] ProductVO productToCreate)
        {
            if (productToCreate == null) return BadRequest();
            var product = await _productRepository.Create(productToCreate);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update([FromBody] ProductVO productToUpdate)
        {
            if (productToUpdate == null) return BadRequest();
            var product = await _productRepository.Update(productToUpdate);
            if (product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var wasDeleted = await _productRepository.Delete(id);
            if (wasDeleted is not true) return NotFound();
            return Ok(wasDeleted);
        }

    }
}
