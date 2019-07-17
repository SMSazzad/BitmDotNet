using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerMVCAPP.Models.Models;
using CustomerMVCAPP.BLL.BLL;

namespace CustomerMVCAPP.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer _customer = new Customer();
        // GET: Customer
        public ActionResult Add()
        {
            _customer.CustomerName = "Saad";
            _customerManager.ADD(_customer);
            return View();
           
        }

        public ActionResult Update()
        {
            ///method 1
            //_customer.CustomerID = 2;
            //_customer.CustomerName = "Rifat";
            //_customerManager.Update(_customer);
            //return View();

            //method 2
            _customer.CustomerID = 2;
            Customer aCustomer = _customerManager.GetById(_customer);
            if(aCustomer != null)
            {
                aCustomer.CustomerName = "Momen";
                _customerManager.Update(aCustomer);
            }
            return View();

        }

        public ActionResult Delete()
        {
            _customer.CustomerID = 2;
            _customerManager.Delete(_customer);
            return View();

        }
    }
}