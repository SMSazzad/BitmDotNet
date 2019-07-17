using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using CustomerMVCAPP.Models.Models;

namespace CustomerMVCAPP.DatabaseContext.DatabaseContext
{
    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}
