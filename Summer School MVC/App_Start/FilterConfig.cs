﻿using System.Web;
using System.Web.Mvc;

namespace Yaz_Okulu_MVC_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
