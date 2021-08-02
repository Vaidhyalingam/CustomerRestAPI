using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Dtos;
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
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customers = repository.GetCustomers().Select(customer => customer.AsDto());            
            return customers;
        }

        [HttpGet("{id}")]
        public CustomerDto GetCustomer(int id)
        {
           var customer = repository.GetCustomer(id);
           return customer.AsDto();
        }

        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            Customer customer = new()
            {
                Id = customerDto.Id,
                Name = customerDto.Name,
                City = customerDto.City,
                PhoneNumber = customerDto.PhoneNumber
            };
            
           repository.CreateCustomer(customer);
           
           return customer.AsDto();
        // return CreatedAtAction(nameof(GetCustomer), new {Id = customer.Id} , customer.AsDto());
        }        
    }
}