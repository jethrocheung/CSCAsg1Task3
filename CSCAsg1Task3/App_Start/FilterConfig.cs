﻿using System.Web;
using System.Web.Mvc;

namespace CSCAsg1Task3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // New code:
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
