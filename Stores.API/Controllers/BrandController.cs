using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrand _brand;
        public BrandController(IBrand brand)
        {
            _brand = brand;
        }
        [HttpGet]
        [Route("get-brands")]
        public async Task<IActionResult> GetBrands()
        {
            List<Brand> brands = await _brand.GetBrands();
            if (brands?.Any() == true)
                return Ok(brands);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            List<Brand> brands = await _brand.GetBrandById(id);
            if (brands?.Any() == true)
                return Ok(brands);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddBrand(Brand brand)
        {
            var result = await _brand.AddBrand(brand);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateBrand(Brand brand)
        {
            var result = await _brand.UpdateBrand(brand);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var result = await _brand.DeleteBrand(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }
}
