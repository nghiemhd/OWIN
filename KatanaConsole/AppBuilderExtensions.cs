using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaConsole
{
    public static class AppBuilderExtensions
    {
        public static void UseMyMiddelware(this IAppBuilder app, MyMiddlewareConfigOptions options)
        {
            app.Use<MyMiddlewareComponent>(options);
        }

        public static void UseMyOtherMiddleware(this IAppBuilder app)
        {
            app.Use<MyOtherMiddlewareComponent>();
        }

        public static void UseAuthentication(this IAppBuilder app)
        {
            app.Use<AuthenticationComponent>();
        }

        public static void UseLogging(this IAppBuilder app)
        {
            app.Use<LoggingComponent>();
        }
    }
}
