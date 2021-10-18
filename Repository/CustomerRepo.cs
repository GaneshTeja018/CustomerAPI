using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAPI.Repository;
using CustomerAPI.FiberConnection;

namespace CustomerAPI.Repository
{
    public class CustomerRepo : ICustomerRepo<Customer>
    {
        private readonly ICustomer<Customer> c_obj;
        public CustomerRepo(ICustomer<Customer> _c_obj)
        {
            c_obj = _c_obj;
        }

        public async Task<int> AddCustomer(Customer c)
        {
            return await c_obj.AddCustomer(c);
        }

        public async Task<int> DeleteCustomer(int id)
        {
            return await c_obj.DeleteCustomer(id);
        }

        public async Task<int> EditCustomer(Customer c, int id)
        {
            return await c_obj.EditCustomer(c,id);
        }

        public async Task<Customer> GetByCustomer(int id)
        {
            return await c_obj.GetByCustomer(id);
        }

        public async Task<List<Customer>> GetCustomer()
        {
            return await c_obj.GetCustomer();
        }

        public Customer GetLoginDetails(Customer c)
        {
            return c_obj.GetLoginDetails(c);
        }
    }
}
