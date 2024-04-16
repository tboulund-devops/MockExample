using Service;

namespace UnitTests;

public class Tests
{
    private BookService _bookService;
    
    [SetUp]
    public void Setup()
    {
        // For testing purposes we configure the Book Service to use our MockRepository.
        // In that way we're disconnecting the test from the actual database and only testing the BookService.
        // Dependency Injection is a smarter approach to do this, but this is just done manually.
        _bookService = new BookService(new MockBookRepository());
    }

    [Test]
    public void GetTest()
    {
        // This test will only do code coverage of the book service, while the book repository is left.
        // Consider to exclude the book repository from code coverage.
        Assert.AreEqual(3, _bookService.GetBooks().Count());
    }
}