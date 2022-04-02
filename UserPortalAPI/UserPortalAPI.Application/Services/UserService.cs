using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPortalAPI.Application.Interfaces;
using UserPortalAPI.Domain.Models;
using UserPortalAPI.Infrastructure.Interfaces;

namespace UserPortalAPI.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers()
        { 
            return _userRepository.GetAllUsers();
        }
    }
}
