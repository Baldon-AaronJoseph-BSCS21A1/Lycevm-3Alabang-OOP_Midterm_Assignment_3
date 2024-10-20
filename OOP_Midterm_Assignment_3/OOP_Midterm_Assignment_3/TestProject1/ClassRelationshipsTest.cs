using ClassLibrary1;
 
namespace TestProject1
{
    public class ClassRelationshipsTest
    {
        [Fact]
        public void AddBook_IncreasesBookCount()
        {
            Library library = new Library();
            Book book = new Book("Title", "Author", "ISBN");
            library.AddBook(book);
            Assert.Single(library.GetBooks());
        }
        
        [Fact]
        public void RemoveBook_DecreasesBookCount()
        {
            Library library = new Library();
            Book book = new Book("Title", "Author", "ISBN");
            library.AddBook(book);
            library.RemoveBook(book);
            Assert.Empty(library.GetBooks());
        }
        
        [Fact]
        public void SearchBook_ReturnsCorrectBook()
        {
            Library library = new Library();
            Book book = new Book("Title", "Author", "ISBN");
            library.AddBook(book);
            Book? foundBook = library.GetBookByTitle("Title"); // Use nullable type
 
            // Ensure foundBook is not null before asserting
            Assert.NotNull(foundBook);
            Assert.Equal(book, foundBook);
        }
        
        [Fact]
        public void CustomerHasAggregationRelationshipWithOrder()
        {
            Customer customer = new Customer();
            Order order1 = new Order(1, "Product1", 99.99);
            Order order2 = new Order(2, "Product2", 149.99);
            customer.AddOrder(order1);
            customer.AddOrder(order2);
            Assert.Contains(order1, customer.GetOrders());
            Assert.Contains(order2, customer.GetOrders());
        }
        
        [Fact]
        public void OrderProcessorHasDependencyRelationshipWithEmailSender()
        {
            EmailSender emailSender = new EmailSender();
            OrderProcessor orderProcessor = new OrderProcessor(emailSender);
            var emailSent = orderProcessor.ProcessOrder(new Order(1, "Product", 99.99));
            Assert.True(emailSent);
        }
    }
}

