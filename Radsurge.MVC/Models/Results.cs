using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Radsurge.MVC.Models
{
    public class Results
    {
        public string MerchantName { get; set; }
        public string MerchantUrl { get; set; }
        public string MerchantProductName { get; set; }
        public string MerchantProductImage { get; set; }
        public string MerchantIncentive { get; set; }        
        public string DeveloperName { get; set; }
        public string DeveloperProductName { get; set; }
        public string DeveloperProductImage { get; set; }
        public string DeveloperProductClaim{ get; set; }
        public string DeveloperProductUrl { get; set; }
    }
}