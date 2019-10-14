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
        public IActionResult GetOne([FromRoute] long id){
            foreach (Customer customer in this.customers)
            {
                if (customer.Id==id)
                {
                    return Ok(customer);
                }
            }
            return new NotFoundObjectResult(new {errorMessage="Could not find resource", errorCode=10});

        }

        [HttpGet ("api/Customer")]
        public IActionResult GetAll(){
            return Ok(this.customers);

        }

        [HttpPost ("api/Customer")]
        public IActionResult Create([FromBody] Customer newCustomer){
            newCustomer.Id = customers.Count +1;
            if(ModelState.IsValid){
                    this.customers.Add(newCustomer);
                foreach (Customer customer in this.customers)
                {
                    if (customer.Id== newCustomer.Id)
                    {
                        return CreatedAtAction("GetOne", new {Id = customer});
                    }
                }
                return base.StatusCode(500, new {errorMessage="Could not store value"}); 
            }
           else{
               return base.ValidationProblem();
           }
            
        }

        [HttpPut ("api/Customer/{id}")]
        public IActionResult Update([FromRoute] long id, [FromBody] Customer updatedCustomer){
            foreach (Customer customer in customers)
            {
                if (customer.Id==updatedCustomer.Id)
                {
                    customer.Firstname=updatedCustomer.Firstname;
                    customer.LastName=updatedCustomer.LastName;
                    customer.Email=updatedCustomer.Email;
                }
            }
            return NoContent();
        }

        [HttpDelete ("api/Customer/{id}")]

        public IActionResult Delete([FromRoute] long id){
            foreach (Customer customer in customers)
            {
                if (customer.Id==id)
                {
                    customers.Remove(customer);
                    return StatusCode(410);
                }
            }
            
            return NotFound();
        }
    }
}