using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiValidation.Filters;
using WebApiValidation.Models;

namespace WebApiValidation.Controllers
{
    public class ProductController : ApiController
    {
        [ParamsFilter]
        public IHttpActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }else
            {
                return BadRequest();
            }
        }
    }
}
