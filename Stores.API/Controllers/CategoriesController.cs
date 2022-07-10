using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stores.Contract.Inferfaces;
using Stores.Models;

namespace Stores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategories _categories;
        public CategoriesController(ICategories categories)
        {
            _categories = categories;
        }
        [HttpGet]
        [Route("get-categories")]
        public async Task<IActionResult> GetBrands()
        {
            List<Categories> categories = await _categories.GetCategories();
            if (categories?.Any() == true)
                return Ok(categories);
            else
                return NoContent();
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetCategoriesById(int id)
        {
            List<Categories> categories = await _categories.GetCategoriesById(id);
            if (categories?.Any() == true)
                return Ok(categories);
            else
                return NoContent();
        }
        [HttpPost]
        [Route("categories")]
        public async Task<IActionResult> AddCategories(Categories categories)
        {
            var result = await _categories.AddCategories(categories);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateCategories(Categories categories)
        {
            var result = await _categories.UpdateCategories(categories);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            var result = await _categories.DeleteCategories(id);
            if (result == 1)
                return Ok();
            else
                return BadRequest();
        }
    }
}
