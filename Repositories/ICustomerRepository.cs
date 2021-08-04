using System.Collections.Generic;
using ProductCatalog.Entities;

namespace ProductCatalog.Repository
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomers();
        void CreateCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}