using Microsoft.Extensions.DependencyInjection;
using LibraryManagerApp;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IBookService, BookService>() // Register BookService for Dependency Injection
    .BuildServiceProvider();

var bookService = serviceProvider.GetService<IBookService>();

// Adding books to the library
bookService!.AddBook(new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 });
bookService.AddBook(new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 });

// Print out all books
Console.WriteLine("All Books:");
foreach (var book in bookService.GetAllBooks())
{
    Console.WriteLine($"{book.Id}: {book.Title} by {book.Author}, {book.Year}");
}

// Find a book by ID and update its information
var bookToUpdate = bookService.GetBookById(1);
bookToUpdate.Title = "Nineteen Eighty-Four"; // Update title
bookService.UpdateBook(bookToUpdate);
Console.WriteLine("\nUpdated Book:");
Console.WriteLine($"{bookToUpdate.Id}: {bookToUpdate.Title} by {bookToUpdate.Author}, {bookToUpdate.Year}");

// Delete a book and print all books again
bookService.DeleteBook(2);
Console.WriteLine("\nAll Books After Deletion:");
foreach (var book in bookService.GetAllBooks())
{
    Console.WriteLine($"{book.Id}: {book.Title} by {book.Author}, {book.Year}");
}