﻿using System.Web;
using System.Web.Mvc;

namespace AHBC_SampleLab_Inventory
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
