using Service;
using Service.Models;

namespace UnitTests;

public class MockBookRepository : IBookRepository
{
    public IEnumerable<Book> ReadBooksFromDatabase()
    {
        return new List<Book>()
        {
            new Book { Title = "Book1", Author = "Author1", Price = 100 },
            new Book { Title = "Book2", Author = "Author2", Price = 200 },
            new Book { Title = "Book3", Author = "Author3", Price = 300 }
        };
    }

    public void SaveBookToDatabase(Book book)
    {
        return;
    }
}