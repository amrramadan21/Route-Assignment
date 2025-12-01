using Microsoft.AspNetCore.Mvc;
using ServiceAbstractionLayer;
using Shared.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PresentationLayer
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // Get All Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _serviceManager.ProductService.GetAllProductsAsync();
            if (products == null || !products.Any())
                return NotFound("No products found.");
            return Ok(products);
        }

        // Get Product By Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await _serviceManager.ProductService.GetProductByIdAsync(id);
            if (product == null)
                return NotFound($"Product with id {id} not found.");
            return Ok(product);
        }

        // Get All Brands
        [HttpGet("brands")]
        public async Task<ActionResult<IEnumerable<BrandDto>>> GetAllBrands()
        {
            var brands = await _serviceManager.ProductService.GetAllBrandsAsync();
            if (brands == null || !brands.Any())
                return NotFound("No brands found.");
            return Ok(brands);
        }

        // Get All Types (rename DTO if needed to avoid System.Type conflict)
        [HttpGet("types")]
        public async Task<ActionResult<IEnumerable<TypeDto>>> GetAllTypes()
        {
            var types = await _serviceManager.ProductService.GetAllTypesAsync();
            if (types == null || !types.Any())
                return NotFound("No types found.");
            return Ok(types);
        }
    }
}
