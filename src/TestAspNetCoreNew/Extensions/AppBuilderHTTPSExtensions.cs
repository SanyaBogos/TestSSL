using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TestAspNetCoreNew.Service;

namespace TestAspNetCoreNew.Extensions
{
    public static class AppBuilderHTTPSExtensions
    {
        public static IApplicationBuilder UseHttpsRedirectService(this IApplicationBuilder builder, X509Certificate2 x509certificate2)
        {
            return builder.UseMiddleware<HttpsRedirectService>(x509certificate2);
        }
    }
}
