using BookStore.dto;
using BookStore.repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryController(CategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet("/categories")]
        public IActionResult getAllCategory()
        {
            try
            {
                return Ok(categoryRepository.GetAll());
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet("/{id}")]
        public IActionResult getById(int id)
        {
            try
            {
                return Ok(categoryRepository.getById(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPut("/updateCate/{id}")]
        public IActionResult Update(int id, CategoryDTO categoryDTO)
        {
            if(id != categoryDTO.id)
            {
                return NotFound();
            }
            try
            {
                this.categoryRepository.update(categoryDTO);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("/deleteCate/{id}")]
        public IActionResult delete(int id)
        {
            try
            {
                this.categoryRepository.delete(id);
                return NoContent();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("/add-category")]
        public IActionResult add(CategoryModel categoryModel)
        {
            try
            {
                var data = this.categoryRepository.add(categoryModel);
                return Ok(data);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
