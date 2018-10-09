using Microsoft.AspNetCore.Mvc;
using SpeedUpCoreAPIExample.Interfaces;
using System.Threading.Tasks;

namespace SpeedUpCoreAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return await _productsService.GetAllProductsAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return await _productsService.GetProductAsync(id);
        }

        // GET /api/products/find
        [HttpGet("find/{sku}")]
        public async Task<IActionResult> FindProductsAsync(string sku)
        {
            return await _productsService.FindProductsAsync(sku);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return await _productsService.DeleteProductAsync(id);
        }
    }
}
