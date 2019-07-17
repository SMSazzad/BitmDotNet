using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMVCAPP.Models.Models;
using CustomerMVCAPP.Repository.Repository;

namespace CustomerMVCAPP.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool ADD(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }

        public Customer GetById(Customer customer)
        {
            return _customerRepository.GetById(customer);
        }

        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }
    }
}
