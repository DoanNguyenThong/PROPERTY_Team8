﻿using System.Web;
using System.Web.Mvc;

namespace PROPERTY_Team8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
