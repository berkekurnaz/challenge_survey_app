﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AChallenge.WebUI.Helpers.Auth
{
    public class AuthFilterRespondent : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("SessionUsernameRespondent") == null)
            {
                context.Result = new RedirectResult("/Home/Index/");
            }
        }
    }
}
