using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class User
    {
        int UserID { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        public User(int id, string name, string email)
        {
            this.UserID = id;
            this.Username = name;
            this.Email = email;
        }
    }
}
