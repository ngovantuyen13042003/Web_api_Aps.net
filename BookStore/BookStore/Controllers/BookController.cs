    using BookStore.dto;
    using BookStore.repository;
    using Microsoft.AspNetCore.Mvc;

    namespace BookStore.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class BookController : ControllerBase
        {
            private readonly BookRepository bookRepository;
            public BookController(BookRepository b)
            {
                this.bookRepository = b;
            }

            [HttpGet("/books")]
            public IActionResult findAll()
            {
                try
                {
                    var books = bookRepository.GetAll();
                    return Ok(books);
                }
                catch
                {
                    return BadRequest();
                }
            }

            [HttpPost("/add-book")]
            public IActionResult addBook(BookDTO bookDTO)
            {
                try
                {
                    var list = this.bookRepository.add(bookDTO);
                    return StatusCode(StatusCodes.Status201Created);
                }
                catch
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            [HttpGet("/find-books-by-categoryId")]
            public IActionResult findBooksBycate(int cateId)
            {
                try
                {
                    var cates = this.bookRepository.findByCategory(cateId);
                    return Ok(cates);
                }catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return BadRequest();
                }
            }


            [HttpDelete("/deleteBook/{id}")]
            public IActionResult deleteById(int bookId)
            {
                try
                {
                    this.bookRepository.delete(bookId);
                    return Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return BadRequest();
                }
            }

            [HttpPut("/updateBook/{id}")]
            public IActionResult update(int id, BookDTO bookDTO)
            {
                try
                {
                    this.bookRepository.update(id, bookDTO);
                    return Ok();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return BadRequest();
                }
            }
            [HttpGet("/book-detail/{id}")]
            public IActionResult bookDetail(int id)
            {
                try
                {
                    var book = this.bookRepository.getById(id);
                    return Ok(book);
                }catch
                {
                    return BadRequest();
                }
            }
        }
    }
