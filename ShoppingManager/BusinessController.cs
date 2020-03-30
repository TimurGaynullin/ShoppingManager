using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ShoppingManager
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BusinessController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            //return Ok("Привет!");
            return BadRequest();
            //return "Привет!";
            //return null;
        }

        //[HttpGet]
        //public string Get()
        //{
        //    return Ok("Привет!");
        //    return "Привет!";
        //    return null;
        //}
    }
}
