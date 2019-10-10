using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace WebAPIBase.Models
{
    public class Customer{

        public long Id{get; set;}

        public string Firstname{get; set;}

        public string LastName{get; set;}

        public string Email{get; set;}

        }
}
