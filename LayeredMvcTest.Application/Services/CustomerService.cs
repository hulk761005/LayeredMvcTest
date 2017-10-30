using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredMvcTest.DataAccess;
using LayeredMvcTest.Domain.Model;

namespace LayeredMvcTest.Application.Services
{
    public class CustomerService
    {
        CustomerRepository _rep = new CustomerRepository();

        public Customer GetCustomerById(int id)
        {
            return _rep.GetCustomerById(id);
        }
        public List<Customer> GetCustomerList(Func<Customer,bool> filter)
        {
            return _rep.GetCustomerList(filter).ToList();
        }
    }
}
