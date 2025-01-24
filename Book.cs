namespace LMS.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }

        public Book(int id, string title, string author, int year, string isbn)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Year} (ISBN: {ISBN})";
        }
    }
}