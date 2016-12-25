using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;
using HBoop.Business.Layer;

namespace HBoop.Api.Controllers
{
    [Route("api/affiliate")]
    public class AffiliateController : BaseController
    {
        public AffiliateController(IBusinessLayer business)
            :base(business)
        {
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Affiliate> Get()
        {
            var affs = InitData.AffiliateSample().ToList();
            this.Business.AffiliateRepository.Insert(affs);
            var result = this.Business.AffiliateRepository.FindAll();
            return result;
        }

        // GET api/values/5
        [Route("api/affiliate/{id}")]
        public Affiliate Get(string id)
        {
            var affiliate = this.Business.AffiliateRepository.Get(id);
            return affiliate;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Affiliate affiliate)
        { 
            this.Business.AffiliateRepository.Insert(affiliate); 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Affiliate affiliate)
        {
            var aff = this.Business.AffiliateRepository.Get(id);

            aff = affiliate;
            aff.Id = id;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
