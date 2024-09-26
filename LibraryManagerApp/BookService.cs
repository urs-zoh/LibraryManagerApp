namespace LibraryManagerApp;

using System.Collections.Generic;
using System.Linq;

public class BookService : IBookService
{
    private readonly List<Book> _books = []; // List to store books in memory

    public IEnumerable<Book> GetAllBooks() => _books; // Return all books

    public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id) ?? throw new InvalidOperationException("No such book found"); // Find a book by ID

    public void AddBook(Book book)
    {
        _books.Add(book);
        Console.WriteLine($"Added: {book.Title} by {book.Author}, {book.Year}");
    }

    public void UpdateBook(Book book)
    {
        var existingBook = GetBookById(book.Id);
        Console.WriteLine($"Updated: {existingBook.Title} to {book.Title}");
        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.Year = book.Year;
    }

    public void DeleteBook(int id)
    {
        var bookToDelete = GetBookById(id);
        _books.Remove(bookToDelete);
        Console.WriteLine($"Deleted: {bookToDelete.Title}");
    }
    public IEnumerable<Book> SearchByAuthor(string author) =>
        _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

    public IEnumerable<Book> SearchByYear(int year) => _books.Where(b => b.Year == year);
}