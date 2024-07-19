using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepositories _repo = new();
        public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.CheckLogin(email, password);
        }
    }
}
