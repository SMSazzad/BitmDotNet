using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using CustomerMVCAPP.DatabaseContext.DatabaseContext;
using CustomerMVCAPP.Models.Models;

namespace CustomerMVCAPP.Repository.Repository
{
    public class CustomerRepository
    {
        CustomerDbContext _db = new CustomerDbContext();
        public bool Add(Customer customer)
        {
            int isExecuted = 0;
            _db.customers.Add(customer);
            isExecuted = _db.SaveChanges();
            if (isExecuted > 0)
                return true;
            else return false;
        }

        public bool Update(Customer customer)
        {
            //method 1
            //int isUpdated = 0;
            //Customer aCustomer = _db.customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            //aCustomer.CustomerName = customer.CustomerName;
            //isUpdated = _db.SaveChanges();
            //if (isUpdated > 0)
            //    return true;
            //else
            //    return false;

            //method 2
            int isUpdated = 0;
            _db.Entry(customer).State = EntityState.Modified;
            isUpdated = _db.SaveChanges();
            if (isUpdated > 0)
                return true;
            else
                return false;
        }

        public Customer GetById(Customer customer)
        {
            Customer aCustomer = _db.customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            return aCustomer;
        }

        public bool Delete(Customer customer)
        {
            int isExecuted = 0;
            Customer aCustomer = _db.customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            _db.customers.Remove(aCustomer);
            isExecuted = _db.SaveChanges();
            if (isExecuted > 0)
                return true;
            else return false;
        }
    }
}
