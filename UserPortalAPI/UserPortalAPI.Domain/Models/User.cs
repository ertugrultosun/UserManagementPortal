using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPortalAPI.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Passphrase { get; set; } = string.Empty;
        public bool IsApproved { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
    }
}
