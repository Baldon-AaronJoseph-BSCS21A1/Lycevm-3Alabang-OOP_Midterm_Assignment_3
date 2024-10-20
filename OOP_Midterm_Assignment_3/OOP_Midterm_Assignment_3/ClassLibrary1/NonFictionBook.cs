public class NonFictionBook : Book
{
    public string Topic { get; set; }
 
    public NonFictionBook(string title, string author, string isbn, string topic) : base(title, author, isbn)
    {
        Topic = topic;
    }
}