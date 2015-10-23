using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseLogging();
            app.UseAuthentication();
            var options = new MyMiddlewareConfigOptions("Greetings!", "Kevin");
            options.IncludeDate = true;

            app.UseMyMiddelware(options);
            //app.UseMyOtherMiddleware();
        }
    }
}
