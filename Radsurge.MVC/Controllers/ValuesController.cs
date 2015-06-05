﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Radsurge.MVC.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public HttpResponseMessage Retrieve(string claimId, string merchantId)
        {
            //http://localhost:50764/api/values/retrieve?claimId=5&merchantId=abcd
            return Request.CreateResponse(HttpStatusCode.OK, "All Good");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Claim
    {
        public string ClaimId { get; set; }
        public string MerchantId { get; set; }
    }
}