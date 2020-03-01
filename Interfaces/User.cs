using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class User
    {
        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public User(int id, string name, string email)
        {
            this.UserID = id;
            this.Username = name;
            this.Email = email;
        }
        public override string ToString()
        {
            return "ID:" + UserID.ToString() + ";Username:" + Username + ";E-Mail:" + Email;
        }
    }
}
