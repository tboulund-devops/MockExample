using Service.Models;

namespace Service;

public interface IBookRepository
{
    IEnumerable<Book> ReadBooksFromDatabase();
    void SaveBookToDatabase(Book book);
}