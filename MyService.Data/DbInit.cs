using System;
using System.Collections.Generic;
using System.Text;

namespace MyService.Data
{
    public class DbInit
    {
        public static void Initialize(ServiceContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
