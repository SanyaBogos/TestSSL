using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAspNetCoreNew.Service
{
    public class HttpsRedirectService
    {
        private readonly RequestDelegate _next;

        public HttpsRedirectService(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {

            if (context.Request.IsHttps)
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.Redirect(string.Format("https://{0}{1}", context.Request.Host.ToString(), context.Request.Path.ToString()), true);
            }
        }
    }
}
