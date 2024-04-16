using System.Data.SqlClient;
using Service.Models;

namespace Service;

public class BookRepository : IBookRepository
{
    public IEnumerable<Book> ReadBooksFromDatabase()
    {
        var conn = new SqlConnection("Server=.;Database=Books;Integrated Security=True;");
        var cmd = new SqlCommand("SELECT * FROM Books", conn);
        conn.Open();
        var reader = cmd.ExecuteReader();
        var books = new List<Book>();
        while (reader.Read())
        {
            books.Add(new Book
            {
                Title = reader.GetString(1),
                Author = reader.GetString(2),
                Price = reader.GetInt32(3)
            });
        }
        conn.Close();
        return books;
    }

    public void SaveBookToDatabase(Book book)
    {
        var conn = new SqlConnection("Server=.;Database=Books;Integrated Security=True;");
        var cmd = new SqlCommand("INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)", conn);
        cmd.Parameters.AddWithValue("@Title", book.Title);
        cmd.Parameters.AddWithValue("@Author", book.Author);
        cmd.Parameters.AddWithValue("@Price", book.Price);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}