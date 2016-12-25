using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HBoop.Business.Layer;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HBoop.Api.Controllers
{

    public class BaseController : Controller
    {
        private readonly  IBusinessLayer _business;

        protected IBusinessLayer Business
        {
            get { return _business; }
        }
        public BaseController(IBusinessLayer business)
        {
            _business = business;
        }
    }
}
