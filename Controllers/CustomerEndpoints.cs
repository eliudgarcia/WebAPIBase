using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace WebAPIBase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerEndpoints: ControllerBase
    {
        [HttpGet]
        public Object Read(){
            var data= new {Id = 1, Firstname="Eliud",LastName="Garcia", Email="eliudjosue.garcia@cemex.com"};
            return data;
        }

        [HttpPost]

        public string Create(){
            return "Created";
        }

        [HttpPut]

        public string Update(){
            return "Update";
        }

        [HttpDelete]

        public string Delete(){
            return "Delete";
        }
    }
}