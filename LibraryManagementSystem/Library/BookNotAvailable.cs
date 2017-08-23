using System;

namespace Library
{
    public class BookNotAvailable : Exception
    {
        public BookNotAvailable(string message) : base(message)
        {
        }
    }
}
