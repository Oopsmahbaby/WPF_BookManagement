using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepositories
    {
        private BookManagementDbContext _context;

        public UserAccount? CheckLogin(string email, string password)
        {
            _context = new BookManagementDbContext();
            return _context.UserAccounts.FirstOrDefault(a => a.Email == email && a.Password == password);
        }
    }
}
