﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredMvcTest.Domain.Model;

namespace LayeredMvcTest.DataAccess
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetCustomerList(Func<Customer, bool> filter);
    }
}
