using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;

namespace HBoop.Api.Controllers
{
    [Route("api/order")]
    public class OrderController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return new List<Order>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Order Get(string id)
        {
            return new Order();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
