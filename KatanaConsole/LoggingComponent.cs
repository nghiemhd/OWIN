using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace KatanaConsole
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class LoggingComponent
    {
        AppFunc next;
        public LoggingComponent(AppFunc next)
        {
            this.next = next;
        }
 
        public async Task Invoke(IDictionary<string, object> environment)
        {
            // Pass everything up through the pipeline first:
            await next.Invoke(environment);
 
            // Do the logging on the way out:
            IOwinContext context = new OwinContext(environment);
            Console.WriteLine("URI: {0} Status Code: {1}", 
                context.Request.Uri, context.Response.StatusCode);
        }
    }
}
