using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace WebAPIBase.Models
{
    public class Customer{

        public long Id{get; set;}
        [MaxLength(25)]
        public string Firstname{get; set;}
        [MaxLength(25)]
        public string LastName{get; set;}

        public string Email{get; set;}

        }
}
