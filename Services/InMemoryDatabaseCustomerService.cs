using System.Collections.Generic;
using System.Linq;
using WebAPIStarterData;
using WebAPIStarterData.Models;

namespace WebAPIBase.Services
{
    public class InMemoryDatabaseCustomerService : ICustomerService
    {
        private WebAPIStarterContext context;

        public InMemoryDatabaseCustomerService(WebAPIStarterContext context){
            this.context=context;
        }
        public Customer Add(Customer newCustomer)
        {
            var addedCustomer = this.context.Customers.Add(newCustomer);
            this.context.SaveChanges();
            return addedCustomer.Entity;
        }

        public void Delete(Customer deleteCustomer)
        {
            this.context.Customers.Remove(deleteCustomer);
            this.context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            return this.context.Customers.ToList();
        }

        public Customer GetOne(long id)
        {
            return this.context.Customers.Find(id);
        }

        public void Update(Customer updatedCustomer)
        {
            this.context.Customers.Update(updatedCustomer);
            this.context.SaveChanges();
        }
    }
}