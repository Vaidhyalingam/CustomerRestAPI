using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Entities;
using ProductCatalog.Repository;

namespace ProductCatalog.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController: ControllerBase
    {
        private readonly ICustomerRepository repository;

        public CustomerController(ICustomerRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            var customers = repository.GetCustomers();
            return customers;
        }

        [HttpGet("{id}")]
        public Customer GetCustomer(int id)
        {
           var customer = repository.GetCustomer(id);
           return customer;
        }

    }
}