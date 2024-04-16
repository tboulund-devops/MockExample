using Service.Models;

namespace Service;

public class BookService
{
    private readonly IBookRepository _repo;

    public BookService(IBookRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<Book> GetBooks()
    {
        return _repo.ReadBooksFromDatabase();
    }

    public void SaveBook(Book book)
    {
        _repo.SaveBookToDatabase(book);
    }
}