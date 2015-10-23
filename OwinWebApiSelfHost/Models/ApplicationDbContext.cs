﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiSelfHost.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyDatabase")
        {

        }

        static ApplicationDbContext()
        {
            Database.SetInitializer(new ApplicationDbInitializer());
        }

        public IDbSet<Company> Companies { get; set; }
    }

    public class ApplicationDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {            
            context.Companies.Add(new Company { Name = "Microsoft" });
            context.Companies.Add(new Company { Name = "Google" });
            context.Companies.Add(new Company { Name = "Apple" });
            context.SaveChanges();
        }
    }
}
