﻿using System.Web;
using System.Web.Mvc;

namespace Preview_Webapi5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
