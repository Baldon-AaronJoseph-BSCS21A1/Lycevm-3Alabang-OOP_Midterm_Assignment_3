using ClassLibrary1;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Library library = new Library();
            Book book = new Book("Title", "Author", "ISBN");

            // Act
            library.AddBook(book);

            // Assert
            Assert.IsNotNull(book.Title);
            Assert.AreEqual("Title", book.Title);
            Assert.IsTrue(library.GetBooks().Count() ==1);
        }
    }
}