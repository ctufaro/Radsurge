using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Radsurge.MVC.Controllers
{
    public class ClaimsController : ApiController
    {
        // GET api/claims
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/claims/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public HttpResponseMessage Retrieve(string claim_id, string merchant_id)
        {
            //http://localhost:50764/api/claims/retrieve?claim_id=a1b2c3&merchant_id=x4y5z6
            return Request.CreateResponse(HttpStatusCode.OK, "All Good");
        }

        // PUT api/claims/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/claims/5
        public void Delete(int id)
        {
        }
    }
}
