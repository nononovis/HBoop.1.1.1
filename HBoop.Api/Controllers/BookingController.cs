using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;
using HBoop.Business.Layer;

namespace HBoop.Api.Controllers
{
    [Route("api/booking")]
    public class BookingController : BaseController        
    {
        public BookingController(IBusinessLayer business)
            :base(business)
        { }

        // GET api/Booking
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return this.Business.BookingRepository.FindAll();
        }

        // GET api/Booking/5
        [HttpGet("{id}")]
        public Booking Get(string id)
        {
            return new Booking();
        }

        // POST api/Booking
        [HttpPost]
        public void Post([FromBody]Booking booking)
        {
        }

        // PUT api/Booking/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Booking booking)
        {
        }

        // DELETE api/Booking/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
