using HIS.IService;
using HIS.Models.Abstraction;
using HIS.Share;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HIS.WebService.Filters
{
    public class HisAuthAttribute : AuthorizeFilter
    {
        private readonly IAuthService _authService;
        public HisAuthAttribute(IAuthService authService)
        {
            this._authService = authService;
        }
        public override async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            context.HttpContext.Request.Headers.TryGetValue(HttpRequestHeader.Authorization.ToString(), out var  token);
            if (this._authService.ValidateToken(token)==false)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult(new { Message = "Token验证错误" });
            }
        }
    }
}
