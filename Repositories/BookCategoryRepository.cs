using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        private BookManagementDbContext _context = new();

        public List<BookCategory> LoadAllBookCate()
        {
            return _context.BookCategories.ToList();
        }
    }
}
