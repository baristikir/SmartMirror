using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
namespace SmartMirror.WebAPI.Models
{
    public class User : Interfaces.User
    {
        public int UserID { get ; private set; }
        public string Username { get ; private set ; }
        public string Email { get ; private set ; }
        public User(int id, string name, string email):base(id,name,email)
        {

        }
    }
}
