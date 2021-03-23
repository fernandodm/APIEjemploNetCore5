using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace WebApplication.Services.Interfaces
{
    public interface IUserService
    {
        public User GetUserByUsername(string username);
    }
}
