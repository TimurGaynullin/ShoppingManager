using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            var list = db.Products.ToList();
            return list;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove(product);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Product entity)
        {
            db.Update(entity);
            db.SaveChanges();
            return Ok(entity);
        }
    }
}
