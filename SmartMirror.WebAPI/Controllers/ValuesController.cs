using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartMirror.WebAPI.Models;
namespace SmartMirror.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        User[] users = new User[]
        {
            new User(1,"name1","email1"),
            new User(2,"name2","email2"),
            new User(3,"name3","email3")
        };
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get(User value)
        {
            return new User[] { value };
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> test()
        {
            return new string[] { "test1", "test1" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post(User value)
        {
            return "succeded";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
