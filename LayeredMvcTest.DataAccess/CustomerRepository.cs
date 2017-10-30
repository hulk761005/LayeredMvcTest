using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredMvcTest.Domain.Model;

namespace LayeredMvcTest.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private SouthwindContext db = new SouthwindContext();

        public Customer GetCustomerById(int id)
        {
            var query = from a in db.Customers
                        where a.Id == id
                        select a;
            return query.FirstOrDefault();
        }
        public IEnumerable<Customer> GetCustomerList(Func<Customer, bool> filter)
        {
            var query = from a in db.Customers
                        select a;
            return query.Where(filter);
        }
    }
}
