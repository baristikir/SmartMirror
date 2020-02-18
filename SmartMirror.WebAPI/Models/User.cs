using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMirror.WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public string Location { get; set; }
        public User(int id,string name,string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
    }
}
