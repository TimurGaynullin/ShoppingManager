using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingManager
{
    [Route("/api/[controller]")]
    public class BusinessController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Привет!";
        }
    }
}
