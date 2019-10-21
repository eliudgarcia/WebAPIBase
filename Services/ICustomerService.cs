using System.Collections.Generic;
using WebAPIStarterData.Models;

namespace WebAPIBase.Services
{
    public interface ICustomerService
    {
        IList<Customer> GetAll();

        Customer GetOne(long id);

        Customer Add(Customer newCustomer);

        void Update(Customer updatedCustomer);

        void Delete(Customer deleteCustomer);
         
    }
}