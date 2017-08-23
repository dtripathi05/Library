using System.Collections.Generic;

namespace Library
{
    public class Horror : Book
    {
        public List<Book> HorrorBooks = new List<Book>();
        public List<Book> GetHorrorBooks()
        {
            return HorrorBooks;
        }
    }
}
