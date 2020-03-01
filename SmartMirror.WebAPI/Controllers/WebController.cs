using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using SmartMirror.WebAPI.Models;
namespace SmartMirror.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebController : ControllerBase
    {
        DB_Manager.DBConnector database;
        public WebController()
        {
            database = new DB_Manager.DBConnector();
        }
        #region users
        [ActionName("users")]
        [HttpGet]
        public ActionResult<IEnumerable<User>> allUsers()
        {
            return database.getAllUsers().ToArray();
        }
        [ActionName("users")]
        [HttpGet("{id}")]
        public ActionResult<User> getUser(int id)
        {
            return database.getUser(id);
        }
        #endregion
    }
}