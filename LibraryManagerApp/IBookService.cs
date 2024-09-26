namespace LibraryManagerApp;

using System.Collections.Generic;

public interface IBookService
{
    IEnumerable<Book> GetAllBooks();      // Get all books
    Book GetBookById(int id);             // Get a book by ID
    void AddBook(Book book);              // Add a new book
    void UpdateBook(Book book);           // Update an existing book
    void DeleteBook(int id);              // Delete a book by ID
    IEnumerable<Book> SearchByAuthor(string author);
    IEnumerable<Book> SearchByYear(int year);
}