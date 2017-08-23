using System.Collections.Generic;

namespace Library
{
    public class Fiction : Book
    {
        public List<Book> FictionBooks = new List<Book>();
        public List<Book> GetFictionBooks()
        {
            return FictionBooks;
        }
    }

}
