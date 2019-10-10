using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using WebAPIBase.Models;
namespace WebAPIBase.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {

        private List<Customer> customers;

        public CustomerController(){
            this.customers= new List<Customer>{
                new Customer {Id = 1, Firstname="Steve",LastName="Bishop", Email="steve.bishop@galvanize.com"},
                new Customer {Id = 2, Firstname="Stve",LastName="Bihop", Email="stee.bishop@galvanize.com"},
                new Customer {Id = 3, Firstname="teve",LastName="Bishp", Email="steve.bihop@galvanize.com"}
            };
        }
        [HttpGet("api/Customer/{id}")]
        public Customer GetOne(int id){
            foreach (Customer customer in this.customers)
            {
                if (customer.Id==id)
                {
                    return customer;
                }
            }
            return null;

        }

        [HttpGet ("api/Customer")]
        public List<Customer> GetAll(){
            return this.customers;

        }

        [HttpPost ("api/Customer")]
        public Customer Create([FromBody] Customer newCustomer){
            newCustomer.Id = customers.Count +1;
            this.customers.Add(newCustomer);
            foreach (Customer customer in this.customers)
            {
                if (customer.Id== newCustomer.Id)
                {
                    return customer;
                }
            }
            return null;
        }

        [HttpPut ("api/Customer/{id}")]
        public string Update([FromRoute] long id, [FromBody] Customer updatedCustomer){
            foreach (Customer customer in customers)
            {
                if (customer.Id==1)
                {
                    customer.Firstname=updatedCustomer.Firstname;
                    customer.LastName=updatedCustomer.LastName;
                    customer.Email=updatedCustomer.Email;
                }
            }
            return "Updated";
        }

        [HttpDelete ("api/Customer/{id}")]

        public string Delete([FromRoute] long id){
            foreach (Customer customer in customers)
            {
                if (customer.Id==id)
                {
                    customers.Remove(customer);
                    break;
                }
            }
            
            return "Delete";
        }
    }
}