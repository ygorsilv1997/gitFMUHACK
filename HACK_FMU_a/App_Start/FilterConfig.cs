﻿using System.Web;
using System.Web.Mvc;

namespace HACK_FMU_a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
