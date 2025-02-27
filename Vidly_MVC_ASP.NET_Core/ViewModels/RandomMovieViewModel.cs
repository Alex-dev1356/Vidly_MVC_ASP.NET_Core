using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_ASP.NET_Core.Models;

namespace Vidly_MVC_ASP.NET_Core.ViewModels
{
	public class RandomMovieViewModel
	{
        public Movie Movie{ get; set; }
        public List<Customer> Customers { get; set; }

    }
}