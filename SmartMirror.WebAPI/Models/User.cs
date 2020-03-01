﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMirror.WebAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        //public string Location { get; set; }
        public User(int id,string name,string email)
        {
            this.UserID = id;
            this.Username = name;
            this.Email = email;
        }
    }
}
