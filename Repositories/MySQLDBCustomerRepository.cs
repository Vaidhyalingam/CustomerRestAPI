using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProductCatalog.Entities;

namespace ProductCatalog.Repository
{
    public class MySQLDBCustomerRepository : ICustomerRepository
    {
        public MySqlConnection Connection;
        public List<Customer> customers = new List<Customer>();
        public MySQLDBCustomerRepository(MySqlConnection mySqlConnection)
        {
            var a = mySqlConnection;
            a.Open();
            string sql = "SELECT * FROM employees";
            MySqlCommand cmd = new MySqlCommand(sql, a);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                customers.Add(new Customer{
                    Id = (int) dataReader["Id"],
                    Name = dataReader["Name"].ToString(),
                    City = dataReader["City"].ToString(),
                    PhoneNumber = dataReader["PhoneNumber"].ToString(),
                });
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {

            return customers;
        }

        public Customer GetCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}