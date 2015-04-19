using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AzureAD.WebApi.SPOnline.WebApi.Controllers
{
    [Authorize]
    public class TestController : ApiController
    {
        [HttpGet]
        public string Test()
        {
            return "OK";
        }
    }
}
