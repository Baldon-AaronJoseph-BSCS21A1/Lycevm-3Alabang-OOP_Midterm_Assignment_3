public class FictionBook : Book
{
    public string Genre { get; set; }
 
    public FictionBook(string title, string author, string isbn, string genre) : base(title, author, isbn)
    {
        Genre = genre;
    }
}
 
 
