using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_DEMO.Models;


    public class BusinessLogic
    {

    Model1 m = new Model1();

        public int Count
        {
            get
            {
                return GetCustomers.Count;
            }
        }

        public List<String> GetCustomerIDs
        {
            get
            {
                return m.Customers.Select<Customer, String>
                                     (c => c.CustomerID).ToList<String>();
            }
        }

        public List<Customer> GetCustomers
        {
            get
            {
                return m.Customers.ToList<Customer>();
            }
        }

        public Customer GetCustomer(string id)
        {
            List<Customer> result = m.Customers.Where
                              (c => c.CustomerID.Equals(id)).ToList<Customer>();
            if (result.Count > 0)
                return result[0];
            else
                return null;
        }
    }
