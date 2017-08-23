using System;
using System.Collections.Generic;

namespace Library
{
    public class Librarian
    {
        List<Book> IssuedBooks = new List<Book>();
        
        public void IssueBook(Book book)
        {
            IssuedBooks.Add(book);
        }
        public List<Book> GetIssuedBooks()
        {
            return IssuedBooks;
        }  
    }

}
