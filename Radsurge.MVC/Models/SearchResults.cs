using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Radsurge.MVC.Models
{
    public class SearchResults
    {
        private List<Results> _returnedResults;
        
        public string SearchTerm { get; set; }
        public List<Results> ReturnedResults 
        {
            get
            {
                return _returnedResults;
            }
        }

        public SearchResults()
        {
            _returnedResults = new List<Results>();
        }
    }

}