using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin;

namespace KatanaConsole
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class MyMiddlewareComponent
    {
        AppFunc next;

        MyMiddlewareConfigOptions configOptions;

        public MyMiddlewareComponent(AppFunc next, MyMiddlewareConfigOptions configOptions)
        {
            this.next = next;
            this.configOptions = configOptions;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            await next.Invoke(environment);

            IOwinContext context = new OwinContext(environment);

            await context.Response.WriteAsync(string.Format("<h1>{0}</h1>", configOptions.GetGreeting()));

            context.Response.StatusCode = 200;
            context.Response.ReasonPhrase = "OK";
        }
    }
}
