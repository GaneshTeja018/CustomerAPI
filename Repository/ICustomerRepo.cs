using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Repository
{
    public interface ICustomerRepo<Customer>
    {
        public Task<int> AddCustomer(Customer c);
        public Task<int> EditCustomer(Customer c, int id);
        public Task<int> DeleteCustomer(int id);
        public Task<List<Customer>> GetCustomer();
        public Task<Customer> GetByCustomer(int id);
        public Customer GetLoginDetails(Customer c);
    }
}
