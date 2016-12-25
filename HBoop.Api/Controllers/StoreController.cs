using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;
using HBoop.Business.Layer;

namespace HBoop.Api.Controllers
{
    [Route("api/store")]
    public class StoreController : BaseController
    {
        public StoreController(IBusinessLayer business)
            :base(business)
        {

        }
        // GET api/Store
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            this.Business.StoreRepository.Insert(InitData.StoreSample().ToList());
            var result = this.Business.StoreRepository.FindAll();
            return result;
        }

        // GET api/Store/5
        [HttpGet("{id}")]
        public Store Get(string id)
        {
            var result = this.Business.StoreRepository.Get(id);
            return result;
        }

        // POST api/Store
        [HttpPost]
        public void Post([FromBody]Store store)
        {
            this.Business.StoreRepository.Insert(store);
        }

        // PUT api/Store/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Store store)
        {
        }

        // DELETE api/Store/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.Business.StoreRepository.Delete(id);
        }
    }
}
