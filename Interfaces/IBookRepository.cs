using LibApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Interfaces 
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetBooks();

        public Book GetBookById(int bookId);

        public void UpdateBook(Book book);

        public void AddBook(Book book);

        public void DeleteBook(int BookId);
    }
}

