using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryManager
    {
        List<Book> Books=new List<Book>() ;
        Fiction fiction = new Fiction();
        public Fiction GetFiction()
        {
            return fiction;
        }
        Technical tech = new Technical();
        public Technical GetTechnical()
        {
            return tech;
        }
        Horror horror = new Horror();
        public Horror GetHorror()
        {
            return horror;
        }
        public List<Book> GetAllBooks()
        {
            return Books;
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
            if (book.Type == "Horror")
            {
                fiction.FictionBooks.Add(book);
            }
            else if (book.Type == "Technical")
            {
                tech.TechnicalBooks.Add(book);
            }
            else
            {
                horror.HorrorBooks.Add(book);
            }
        }
    }

}
