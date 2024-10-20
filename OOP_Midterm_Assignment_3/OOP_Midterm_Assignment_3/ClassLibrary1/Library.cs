using System.Collections.Generic;
using System.Linq;
 
public class Library
{
    private List<Book> books;
 
    public Library()
    {
        books = new List<Book>();
    }
 
    public void AddBook(Book book)
    {
        books.Add(book);
    }
 
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
 
    public Book? GetBookByTitle(string title) // Marked as nullable
    {
        return books.FirstOrDefault(b => b.Title == title);
    }
 
    public List<Book> GetBooks()
    {
        return books;
    }
}