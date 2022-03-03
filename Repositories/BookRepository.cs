using LibApp.Models;
using LibApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp.Data;
using Microsoft.EntityFrameworkCore;

namespace LibApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.Include(b => b.Genre);
        }
        public Book GetBookById(int Id) => _context.Books.Find(Id);

        public void AddBook(Book book) => _context.Books.Add(book);

        public void UpdateBook(Book book) => _context.Books.Update(book);

        public void DeleteBook(int BookId) => _context.Books.Remove(GetBookById(BookId));

        public void Save() => _context.SaveChanges();

        public Book Details(int id)
        {
            return _context.Books.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);
        }
    }
}
