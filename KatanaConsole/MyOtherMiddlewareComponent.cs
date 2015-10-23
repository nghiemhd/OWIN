using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin;

namespace KatanaConsole
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class MyOtherMiddlewareComponent
    {
        AppFunc next;

        public MyOtherMiddlewareComponent(AppFunc next)
        {
            this.next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);
            await context.Response.WriteAsync("<h1>Hello from my second Middleware.</h1>");
            await next.Invoke(environment);
        }
    }
}
