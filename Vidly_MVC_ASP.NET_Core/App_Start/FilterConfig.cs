﻿using System.Web;
using System.Web.Mvc;

namespace Vidly_MVC_ASP.NET_Core
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
