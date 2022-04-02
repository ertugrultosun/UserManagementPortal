using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPortalAPI.Domain.Models;

namespace UserPortalAPI.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
