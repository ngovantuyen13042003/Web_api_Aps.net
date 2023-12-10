using BookStore.Model;
using BookStore.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AuthController : ControllerBase
    {
        private readonly CustomerRepository customerRepository;
        public AuthController(CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpPost("/register")]
        public IActionResult register(String username, String password )
        {
            try
            {
                var customer = this.customerRepository.register(username, password);
                return StatusCode(StatusCodes.Status201Created);
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("/login")]
        public IActionResult login(String username, String password)
        {
            try
            {
                var cus = this.customerRepository.login(username, password);
                return Ok(cus);
            }catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
