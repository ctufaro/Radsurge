using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Text;
using Newtonsoft.Json;

namespace Radsurge.MVC.Controllers
{
    public class CouponsController : ApiController
    {
        // GET rest/coupons
        public HttpResponseMessage Get()
        {
            var coupon = new Coupon
            {
                BigMessage = "Favorite Product Deal",
                CompanyLogo = "Company Logo",
                LittleMessage = "Get 15% from www.yourcompany.com"
            };

            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(coupon), Encoding.UTF8, "application/json");
            return response;
        }

        // GET rest/coupons/5
        public string Get(int id)
        {
            return "value";
        }

        // POST rest/coupons
        public void Post([FromBody]string value)
        {
        }

        // PUT rest/coupons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE rest/coupons/5
        public void Delete(int id)
        {
        }
    }

    public class Coupon
    {
        public string BigMessage { get; set; }
        public string LittleMessage { get; set; }
        public string CompanyLogo { get; set; }
    }
}
