using LMS.Models;

namespace LMS.Models
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int id)
        {
            books.RemoveAll(book => book.Id == id);
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(book => book.Id == id);
        }
    }
}