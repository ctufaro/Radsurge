﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Radsurge.MVC.EntityModel;

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
            set
            {
                _returnedResults = value;
            }
        }
        public SearchResults()
        {
            _returnedResults = new List<Results>();
        }
    }

}