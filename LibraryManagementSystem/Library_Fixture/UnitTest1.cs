using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
namespace Library_Fixture
{
    [TestClass]
    public class Library
    {
        [TestMethod]
        public void Number_Of_Books_InLibrary()
        {
            Book book1 = new Book() { Name = "Harry Potter 1", Price = 250, Type = "Fiction", Id = 1 };
            Book book2 = new Book() { Name = "Harry Potter 2", Price = 250, Type = "Fiction", Id = 2 };
            Book book3 = new Book() { Name = "Conjuring 1", Price = 250, Type = "Horror", Id = 3 };
            Book book4 = new Book() { Name = "Conjuring 2", Price = 250, Type = "Horror", Id = 4 };
            Book book5 = new Book() { Name = "Let us C", Price = 250, Type = "Technical", Id = 5 };
            Book book6 = new Book() { Name = "Let us C#", Price = 250, Type = "Technical", Id = 6 };
            LibraryManager library = new LibraryManager();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            Assert.AreEqual(6, library.GetAllBooks().Count);
        }
        [TestMethod]
        public void Number_Of_DifferentBooks()
        {
            Book book1 = new Book() { Name = "Harry Potter 1", Price = 250, Type = "Fiction", Id = 1 };
            Book book2 = new Book() { Name = "Harry Potter 2", Price = 250, Type = "Fiction", Id = 2 };
            Book book3 = new Book() { Name = "Conjuring 1", Price = 250, Type = "Horror", Id = 3 };
            Book book4 = new Book() { Name = "Conjuring 2", Price = 250, Type = "Horror", Id = 4 };
            Book book5 = new Book() { Name = "Let us C", Price = 250, Type = "Technical", Id = 5 };
            Book book6 = new Book() { Name = "Let us C#", Price = 250, Type = "Technical", Id = 6 };
            LibraryManager library = new LibraryManager();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            Assert.AreEqual(2, library.GetFiction().GetFictionBooks().Count);
            Assert.AreEqual(2, library.GetHorror().GetHorrorBooks().Count);
            Assert.AreEqual(2, library.GetTechnical().GetTechnicalBooks().Count);
        }
        [TestMethod]
        public void Number_Of_IssuedBooksFromLibrary()
        {
            Book book1 = new Book() { Name = "Harry Potter 1", Price = 250, Type = "Fiction", Id = 1 };
            Book book2 = new Book() { Name = "Harry Potter 2", Price = 250, Type = "Fiction", Id = 2 };
            Book book3 = new Book() { Name = "Conjuring 1", Price = 250, Type = "Horror", Id = 3 };
            Book book4 = new Book() { Name = "Conjuring 2", Price = 250, Type = "Horror", Id = 4 };
            Book book5 = new Book() { Name = "Let us C", Price = 250, Type = "Technical", Id = 5 };
            Book book6 = new Book() { Name = "Let us C#", Price = 250, Type = "Technical", Id = 6 };
            LibraryManager library = new LibraryManager();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            Librarian librarian = new Librarian();
            librarian.IssueBook(book1);
            librarian.IssueBook(book6);
            librarian.IssueBook(book2);
            librarian.IssueBook(book4);
            Assert.AreEqual(4, librarian.GetIssuedBooks().Count);
        }
        [TestMethod]
        public void Name_Of_IssuedBooksFromLibrary()
        {

            Book book1 = new Book() { Name = "Harry Potter 1", Price = 250, Type = "Fiction", Id = 1 };
            Book book2 = new Book() { Name = "Harry Potter 2", Price = 250, Type = "Fiction", Id = 2 };
            Book book3 = new Book() { Name = "Conjuring 1", Price = 250, Type = "Horror", Id = 3 };
            Book book4 = new Book() { Name = "Conjuring 2", Price = 250, Type = "Horror", Id = 4 };
            Book book5 = new Book() { Name = "Let us C", Price = 250, Type = "Technical", Id = 5 };
            Book book6 = new Book() { Name = "Let us C#", Price = 250, Type = "Technical", Id = 6 };
            LibraryManager library = new LibraryManager();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            Librarian librarian = new Librarian();
            librarian.IssueBook(book1);
            librarian.IssueBook(book6);
            librarian.IssueBook(book2);
            librarian.IssueBook(book4);
            Assert.AreEqual("Harry Potter 1", librarian.GetIssuedBooks()[0].Name);
            Assert.AreEqual("Let us C#", librarian.GetIssuedBooks()[1].Name);
            Assert.AreEqual("Harry Potter 2", librarian.GetIssuedBooks()[2].Name);
            Assert.AreEqual("Conjuring 2", librarian.GetIssuedBooks()[3].Name);
        }
    }
}