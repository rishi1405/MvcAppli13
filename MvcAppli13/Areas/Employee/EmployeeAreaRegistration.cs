﻿using System.Web.Mvc;

namespace MvcAppli13.Areas.Employee
{
    public class EmployeeAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Employee";
            }
        }

        //public override void RegisterArea(AreaRegistrationContext context)
        //{
        //    context.MapRoute(
        //        "Employee_default",
        //        "Employee/{controller}/{action}/{id}",
        //        new { action = "Index", id = UrlParameter.Optional }
        //    );
        //}

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Employee_default",
                "Employee/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }


    }
}
