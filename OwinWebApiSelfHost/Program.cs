using Microsoft.Owin.Hosting;
using OwinWebApiSelfHost.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {            
            string baseUri = "http://localhost:9999";

            Console.WriteLine("Starting web server...");
            WebApp.Start<Startup>(baseUri);
            Console.WriteLine("Server running at {0} - press Enter to quit.", baseUri);
            Console.ReadLine();
        }
    }
}
