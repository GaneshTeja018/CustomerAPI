using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAPI.FiberConnection;
using CustomerAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CustomerController));

        private readonly ICustomerServ<Customer> c_serv;
        public CustomerController(ICustomerServ<Customer> _c_serv)
        {
            c_serv = _c_serv;
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer c)
        {
            _log4net.Info($"Adding the Customer {c.CustomerName}");
            return Ok(await c_serv.AddCustomer(c));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            _log4net.Info($"Deleting the Customer {id}");
            return Ok(await c_serv.DeleteCustomer(id));
        }
        [HttpPut]
        public async Task<IActionResult> EditCustomer(Customer c, int id)
        {
            _log4net.Info($"Editing the Customer {c.CustomerName}");
            return Ok(await c_serv.EditCustomer(c, id));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByCustomer(int id)
        {
            _log4net.Info($"Getting the Customer by {id}");
            return Ok( await c_serv.GetByCustomer(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            _log4net.Info($"Getting All the Customer");
            return Ok( await c_serv.GetCustomer());
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult GetLoginDetails(Customer c)
        {
            _log4net.Info($"Getting Login the Customer {c.CustomerMailId}");
            return Ok(c_serv.GetLoginDetails(c));
        }
    }
}
