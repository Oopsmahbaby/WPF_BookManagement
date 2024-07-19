using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookRepositories _repo = new();
        public List<Book> GetAllBooks()
        {
            return _repo.GetAllBooks();
        }
        public void DeleteBook(Book book)
        {
            _repo.DeleteBook(book);
        }

        public void AddBook(Book book)
        {
            _repo.AddBook(book);
        }

        public Book? CheckIdExist(int id) 
        {
            return _repo.CheckIdExist(id);
        }

        public void UpdateBook(Book book)
        {
            _repo.UpdateBook(book);
        }
    }
}
