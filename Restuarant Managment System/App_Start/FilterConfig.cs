﻿using System.Web;
using System.Web.Mvc;

namespace Restuarant_Managment_System
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
