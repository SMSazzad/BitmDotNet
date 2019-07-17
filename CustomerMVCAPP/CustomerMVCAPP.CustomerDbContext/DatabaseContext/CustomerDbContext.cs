using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMVCAPP.Models.Models;

namespace CustomerMVCAPP.CustomerDbContext.DatabaseContext
{
    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}
