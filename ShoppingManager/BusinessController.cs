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
        public ProductContext db;
        public BusinessController(ProductContext context)
        {
            db = context;
        }

        [HttpGet]
        public List<Product> Get()
        {
            db.Products.Add(new Product { Name = "Горький шоколад", Amount = 1, Discount = 0, Price = 70 });
            db.SaveChanges();
            var list = db.Products.ToList();
            return list;
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
