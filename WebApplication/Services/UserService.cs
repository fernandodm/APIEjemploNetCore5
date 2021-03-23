using System;
using System.Linq;
using TodoApi.Models;
using WebApplication.Services.Interfaces;

namespace WebApplication.Services
{
    public class UserService : IUserService
    {
        private readonly TodoContext _context;

        public UserService(TodoContext context)
        {
            _context = context;
        }

        public User GetUserByUsername(string userName)
        {
            return _context.Users.SingleOrDefault(x => x.Username == userName);
        }
    }
}
