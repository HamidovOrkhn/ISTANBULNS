using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IstanbulNsApp.Filters
{
    public class AuthUser : Attribute, IActionFilter
    {
        int UserType;
        public AuthUser(int utype)
        {
            UserType = utype;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("UserFilter");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("JwtSession") == null)
            {
                context.HttpContext.Session.SetString("JwtSession", context.HttpContext.Request.Cookies["jwtToken"]);
            }
            if (context.HttpContext.Request.coo)
            {

            }
        }
    }
}
