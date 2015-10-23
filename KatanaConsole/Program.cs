using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;

namespace KatanaConsole
{    
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Startup>("http://localhost:9999");
            Console.WriteLine("Server started. Press any key to quit.");
            Console.ReadLine();
        }
    }    
}
