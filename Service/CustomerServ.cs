using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAPI.FiberConnection;
using CustomerAPI.Repository;

namespace CustomerAPI.Service
{
    public class CustomerServ : ICustomerServ<Customer>
    {
        private readonly ICustomerRepo<Customer> c_repo;
        public CustomerServ(ICustomerRepo<Customer> _c_repo)
        {
            c_repo = _c_repo;
        }
        public async Task<int> AddCustomer(Customer c)
        {
            return await c_repo.AddCustomer(c);
        }

        public async Task<int> DeleteCustomer(int id)
        {
            return await c_repo.DeleteCustomer(id);
        }

        public async Task<int> EditCustomer(Customer c, int id)
        {
            return await c_repo.EditCustomer(c, id);
        }

        public async Task<Customer> GetByCustomer(int id)
        {
            return await c_repo.GetByCustomer(id);
        }

        public async Task<List<Customer>> GetCustomer()
        {
            return await c_repo.GetCustomer();
        }

        public Customer GetLoginDetails(Customer c)
        {
            return c_repo.GetLoginDetails(c);
        }
    }
}
