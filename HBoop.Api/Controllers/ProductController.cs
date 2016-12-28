﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HBoop.Model.Bson.Entities;
using HBoop.Business.Layer;

namespace HBoop.Api.Controllers
{
    [Route("api/product")]
    public class ProductController : BaseController
    {
        public ProductController(IBusinessLayer business)
            : base(business){ }

        // GET api/Product
        [HttpGet]
        public IEnumerable<ProductCategory> GetPrdCat()
        {
            var result = this.Business.ProductCategoryRepository.FindAll();
            return result;
        }

        // GET api/Product
        [HttpGet]
        public IEnumerable<Product> GetPrd()
        {
            var result = this.Business.ProductRepository.FindAll();
            return result;
        }

        // GET api/Product/5
        [HttpGet("{id}")]
        public Product GetPrd(string id)
        {
            return this.Business.ProductRepository.Get(id);
        }

        // POST api/Product
        [HttpPost]
        public void PostPrd([FromBody]Product product)
        {
            this.Business.ProductRepository.Insert(product);
        }

        // PUT api/Product/5
        [HttpPut("{id}")]
        public void PutPrd(string id, [FromBody]Product product)
        {
        }

        // DELETE api/Product/5
        [HttpDelete("{id}")]
        public void DeletePrd(string id)
        {
            this.Business.ProductRepository.Delete(id);
        }
    }
}
