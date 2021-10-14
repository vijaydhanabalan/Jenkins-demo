using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace demo.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/Default/GetName")]
        [HttpGet]
        public IHttpActionResult GetName()
        {
            DefaultService defaultService = new DefaultService();
            string name = defaultService.GetNameFromDB();
            return Ok(name);
        }
    }
}
