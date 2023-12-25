using BookStore.Data;
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

            private readonly DataContext context;
            public BookController(BookRepository b, DataContext context)
            {
                this.bookRepository = b;
            this.context = context;
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
                    var book = this.bookRepository.add(bookDTO);
                    return Ok(book);
                }
                catch
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }

            [HttpGet("/find-books-by-categoryId/{cateId}")]
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
            public IActionResult deleteById(int id)
            {
                try
                {
                    this.bookRepository.delete(id);
                    return Ok("Deleted successfull!");
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
                    return Ok("Updated successfull!");
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


            [HttpGet("/pagination")]
            public IActionResult pagination(int page, int pagesize)
            {
            try
            {
                var books = this.bookRepository.pagination(page, pagesize);
                var size = this.context.books.Count();

                var result = new
                {
                    book = books,
                    size = size
                };

                return Ok(result);
            }catch
            {
                return BadRequest();
            }
            }

        [HttpGet("/search")]
        public IActionResult timkiem(string keyword)
        {
            try
            {
                var books = this.bookRepository.Search(keyword);
                return Ok(books);
            }
            catch
            {
                return BadRequest();
            }
        }





    }
    }
