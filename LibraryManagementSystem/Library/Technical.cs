using System.Collections.Generic;

namespace Library
{
    public class Technical : Book
    {
        public List<Book> TechnicalBooks = new List<Book>();
        public List<Book> GetTechnicalBooks()
        {
            return TechnicalBooks;
        }
    }

}
