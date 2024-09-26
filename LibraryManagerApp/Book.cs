namespace LibraryManagerApp;

public class Book
{
    public int Id { get; init; }       // Unique identifier of the book
    public required string Title { get; set; }  // Title of the book
    public required string Author { get; set; } // Author of the book
    public int Year { get; set; }      // Year the book was published
}