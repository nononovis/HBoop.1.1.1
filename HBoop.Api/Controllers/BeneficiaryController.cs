using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;
using HBoop.Business.Layer;

namespace HBoop.Api.Controllers
{
    [Route("api/beneficiary")]
    public class BeneficiaryController : BaseController
    {
        public BeneficiaryController(IBusinessLayer business)
            :base(business)
        { }
        // GET api/values
        [HttpGet]
        public IEnumerable<Beneficiary> Get()
        {
            return this.Business.BeneficiaryRepository.FindAll();
        }

        // GET api/Beneficiary/5
        [HttpGet("{id}")]
        public Beneficiary Get(string id)
        {
            return this.Business.BeneficiaryRepository.Get(id);
        }

        // POST api/Beneficiary
        [HttpPost]
        public void Post([FromBody]Beneficiary beneficiary)
        {
            this.Business.BeneficiaryRepository.Insert(beneficiary);
        }

        // PUT api/Beneficiary/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Beneficiary beneficiary)
        {
        }

        // DELETE api/Beneficiary/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.Business.BeneficiaryRepository.Delete(id);
        }
    }
}
