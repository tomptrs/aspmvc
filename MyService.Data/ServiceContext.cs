using Microsoft.EntityFrameworkCore;
using MyService.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyService.Data
{
    public class ServiceContext:DbContext
    {

        public ServiceContext(DbContextOptions<ServiceContext> options):base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
       
    }
}
