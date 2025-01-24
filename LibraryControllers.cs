using Microsoft.AspNetCore.Mvc;
using LMS.Models;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private static Library _library = LibraryFactory.CreateLibrary();

        // GET api/library - Get all books
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(_library.GetBooks());
        }

        // GET api/library/{id} - Get a book by ID
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _library.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // POST api/library - Add a new book to the library
        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            _library.AddBook(book);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        // DELETE api/library/{id} - Remove a book by ID
        [HttpDelete("{id}")]
        public ActionResult RemoveBook(int id)
        {
            var book = _library.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            _library.RemoveBook(id);
            return NoContent();
        }
    }
}