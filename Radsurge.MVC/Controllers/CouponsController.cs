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
        // GET api/coupons
        [System.Web.Http.AcceptVerbs("GET")]
        public HttpResponseMessage Show()
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

        // GET api/coupons
        [System.Web.Http.AcceptVerbs("GET")]
        public HttpResponseMessage Status()
        {
            var coupon = new Coupon
            {
                big_message = "Favorite Product Deal2",
                company_logo = "Company Logo2",
                little_message = "Get 15% from2 ..."
            };

            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(coupon), Encoding.UTF8, "application/json");
            return response;
        }

        // GET api/coupons/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/coupons
        public void Post([FromBody]string value)
        {
        }

        // PUT api/coupons/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/coupons/5
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
