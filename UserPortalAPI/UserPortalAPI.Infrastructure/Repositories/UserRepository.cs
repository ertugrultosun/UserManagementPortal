using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPortalAPI.Infrastructure.Interfaces;
using UserPortalAPI.Domain.Models;

namespace UserPortalAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>();

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
