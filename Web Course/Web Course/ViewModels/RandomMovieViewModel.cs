using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Course.Models;

namespace Web_Course.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}