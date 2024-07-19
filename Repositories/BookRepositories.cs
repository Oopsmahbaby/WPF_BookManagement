﻿using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepositories
    {
        private BookManagementDbContext _context = new();

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void AddBook(Book book)
        {

            _context.Books.Add(book);
        }
    }
}
