using BookStore.dto;
using BookStore.repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly CartRepository cartRepository;

        public CartController(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        [HttpPost("/add-to-cart")]
        public IActionResult AddToCart(CartDTO cartDTO)
        {
            try
            {
                var cart = this.cartRepository.add(cartDTO);
                return StatusCode(StatusCodes.Status201Created);
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("/get-all")]
        public IActionResult GetAll()
        {
            try
            {
                var list = this.cartRepository.GetAll();
                return Ok(list);
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete("/remove-from-cart")]
        public IActionResult Remove(int id)
        {
            try
            {
                this.cartRepository.delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
