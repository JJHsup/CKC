using Response_Test.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Response_Test.Controllers.API
{
    [RoutePrefix("api/[Controller]/[action]")]
    public class TesterController : ApiController
    {
        [HttpGet]
        public List<string> TesterName()
        {
            CatchNowTester name = new CatchNowTester();
            List<string> result = new List<string>();
            result.Add(name.Name());
            return result;
        }
    }
}