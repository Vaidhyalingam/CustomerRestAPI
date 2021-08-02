using System.Globalization;
using ProductCatalog.Dtos;
using ProductCatalog.Entities;

namespace ProductCatalog
{
    public static class Extensions
    {
        public static CustomerDto AsDto(this Customer customer)
        {
            return new CustomerDto
            {                
                Id = customer.Id,
                Name = customer.Name,
                City = customer.City,
                PhoneNumber = customer.PhoneNumber
                
            };
        }
    }
}