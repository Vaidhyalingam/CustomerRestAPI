using System.Collections.Generic;
using ProductCatalog.Entities;

namespace ProductCatalog.Repository
{
    public class InMemCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new()
        {
            new Customer
            {
                Id = 1,
                Name = "Harry",
                City = "Alaska",
                PhoneNumber = "111-111-1111"
            },
            new Customer
            {
                Id = 2,
                Name = "Ron",
                City = "Washington",
                PhoneNumber = "222-222-2222"
            }
        };

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            return customers.Find(customer => customer.Id == id);
        }

        public void CreateCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}