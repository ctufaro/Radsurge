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
                big_message = "Favorite Product Deal",
                company_logo = "Company Logo",
                little_message = "Get 15% from ..."
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
        public string big_message { get; set; }
        public string little_message { get; set; }
        public string company_logo { get; set; }
    }
}
