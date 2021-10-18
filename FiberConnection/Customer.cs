using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

#nullable disable

namespace CustomerAPI.FiberConnection
{
    public partial class Customer:ICustomer<Customer>
    {
        private readonly fiber_connectionContext fcc = new fiber_connectionContext();

        public Customer()
        {
            Billings = new HashSet<Billing>();
            Statuses = new HashSet<Status>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAadharNo { get; set; }
        public string CustomerMailId { get; set; }
        public string CustomerPassword { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }

        public async Task<int> AddCustomer(Customer c)
        {
            fcc.Customers.Add(c);
            return await fcc.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomer(int id)
        {
            Customer c=fcc.Customers.Find(id);
            fcc.Customers.Remove(c);
            return await fcc.SaveChangesAsync();
        }

        public async Task<int> EditCustomer(Customer c, int id)
        {
            fcc.Entry(c).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            return await fcc.SaveChangesAsync();
        }

        public async Task<Customer> GetByCustomer(int id)
        {
            return await fcc.Customers.FindAsync(id);
        }

        public async Task<List<Customer>> GetCustomer()
        {
            return await fcc.Customers.ToListAsync();
        }

        public Customer GetLoginDetails(Customer c)
        {
            Customer result = (from i in fcc.Customers
                          where c.CustomerMailId == i.CustomerMailId
                          && c.CustomerPassword == i.CustomerPassword
                          select i).FirstOrDefault();
            return result;
        }
    }
}
