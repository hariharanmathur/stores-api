using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        public ProductController(IProduct products)
        {
            _product = products;
        }
        [HttpGet]
        [Route("get-product")]
        public async Task<IActionResult> GetProducts()
        {
            List<Product> products = await _product.GetProducts();
            if (products?.Any() == true)
                return Ok(products);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> ProductById(int id)
        {
            List<Product> product = await _product.GetProductById(id);
            if (product?.Any() == true)
                return Ok(product);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var result = await _product.AddProduct(product);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var result = await _product.UpdateProduct(product);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _product.DeleteProduct(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }

}
