﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaConsole
{
    public class MyMiddlewareConfigOptions
    {
        string greetingTextFormat = "{0} from {1}{2}";

        public MyMiddlewareConfigOptions(string greeting, string greeter)
        {
            GreetingText = greeting;
            Greeter = greeter;
            Date = DateTime.Now;
        }

        public string GreetingText { get; set; }

        public string Greeter { get; set; }

        public DateTime Date { get; set; }

        public bool IncludeDate { get; set; }

        public string GetGreeting()
        {
            string dateText = string.Empty;
            if (IncludeDate)
            {
                dateText = string.Format(" on {0}", Date.ToShortDateString());
            }
            return string.Format(greetingTextFormat, GreetingText, Greeter, dateText);
        }
    }
}
