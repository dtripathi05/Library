using System;
using System.Collections.Generic;

namespace Library
{
    public class Librarian
    {
        List<Book> IssuedBooks = new List<Book>();
        
        public void IssueBook(Book book)
        {

            if (book.BookCount != 0)
            {
                IssuedBooks.Add(book);
                book.BookCount -= 1;
            }
            else
                throw new BookNotAvailable("book is not available");
        }
        public List<Book> GetIssuedBooks()
        {
            return IssuedBooks;
        }  
    }

}
