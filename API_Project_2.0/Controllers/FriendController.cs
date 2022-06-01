using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Project_2._0.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Project_2._0.Controllers
{
    [Route("api/[controller]")]
    public class FriendController : Controller
    {
        List<Friend> friendsList = new List<Friend>
        {
            new Friend(1, "Daniel", "Wadkins", "Florida", DateTime.Today),
            new Friend(2, "Rodrigo", "Retana", "Ohio", DateTime.Today),
            new Friend(3, "John Peyton", "Feathers", "Texas", DateTime.Today),
            new Friend(4, "Garrett", "Arnold", "Georgia", DateTime.Today)
        };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Friend> Get()
        {
            return friendsList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
